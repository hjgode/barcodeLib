using System;

namespace BarcodeLib.Symbologies
{
    /// <summary>
    ///  UPC-E encoding
    ///  Written by: Brad Barnhill
    /// </summary>
    class UPCE : BarcodeCommon, IBarcode
    {
        private readonly string[] EAN_CodeA = { "0001101", "0011001", "0010011", "0111101", "0100011", "0110001", "0101111", "0111011", "0110111", "0001011" };
        private readonly string[] EAN_CodeB = { "0100111", "0110011", "0011011", "0100001", "0011101", "0111001", "0000101", "0010001", "0001001", "0010111" };
        private readonly string[] UPCE_Code_0 = { "bbbaaa", "bbabaa", "bbaaba", "bbaaab", "babbaa", "baabba", "baaabb", "bababa", "babaab", "baabab" };
        private readonly string[] UPCE_Code_1 = { "aaabbb", "aababb", "aabbab", "aabbba", "abaabb", "abbaab", "abbbaa", "ababab", "ababba", "abbaba" };

        /// <summary>
        /// Encodes a UPC-E symbol.
        /// </summary>
        /// <param name="input">Data to encode.</param>
        public UPCE(string input)
        {
            Raw_Data = input;
        }//UPCE
        /// <summary>
        /// Encode the raw data using the UPC-E algorithm.
        /// </summary>
        private string Encode_UPCE()
        {
            if (Raw_Data.Length != 6 && Raw_Data.Length != 8 && Raw_Data.Length != 12) Error("EUPCE-1: Invalid data length. (8 or 12 numbers only)");

            if (!CheckNumericOnly(Raw_Data)) Error("EUPCE-2: Numeric only.");

            if (Raw_Data.Length == 6)
            {
                Raw_Data = UpcE6ToUpcE8(Raw_Data);
            }

            int CheckDigit = Int32.Parse(Raw_Data[Raw_Data.Length - 1].ToString());
            int NumberSystem = Int32.Parse(Raw_Data[0].ToString());

            //Convert to UPC-E from UPC-A if necessary
            if (Raw_Data.Length == 12)
            {
                string UPCECode = "";

                //break apart into components
                string Manufacturer = Raw_Data.Substring(1, 5);
                string ProductCode = Raw_Data.Substring(6, 5);

                //check for a valid number system
                if (NumberSystem != 0 && NumberSystem != 1)
                    Error("EUPCE-3: Invalid Number System (only 0 & 1 are valid)");

                if (Manufacturer.EndsWith("000") || Manufacturer.EndsWith("100") || Manufacturer.EndsWith("200") && Int32.Parse(ProductCode) <= 999)
                {
                    //rule 1
                    UPCECode += Manufacturer.Substring(0, 2); //first two of manufacturer
                    UPCECode += ProductCode.Substring(2, 3); //last three of product
                    UPCECode += Manufacturer[2].ToString(); //third of manufacturer
                }//if
                else if (Manufacturer.EndsWith("00") && Int32.Parse(ProductCode) <= 99)
                {
                    //rule 2
                    UPCECode += Manufacturer.Substring(0, 3); //first three of manufacturer
                    UPCECode += ProductCode.Substring(3, 2); //last two of product
                    UPCECode += "3"; //number 3
                }//else if
                else if (Manufacturer.EndsWith("0") && Int32.Parse(ProductCode) <= 9)
                {
                    //rule 3
                    UPCECode += Manufacturer.Substring(0, 4); //first four of manufacturer
                    UPCECode += ProductCode[4]; //last digit of product
                    UPCECode += "4"; //number 4
                }//else if
                else if (!Manufacturer.EndsWith("0") && Int32.Parse(ProductCode) <= 9 && Int32.Parse(ProductCode) >= 5)
                {
                    //rule 4
                    UPCECode += Manufacturer; //manufacturer
                    UPCECode += ProductCode[4]; //last digit of product
                }//else if
                else
                    Error("EUPCE-4: Illegal UPC-A entered for conversion.  Unable to convert.");

                Raw_Data = UPCECode;
            }//if

            //get encoding pattern 

            string pattern = NumberSystem == 0 ? UPCE_Code_0[CheckDigit] : UPCE_Code_1[CheckDigit];

            //encode the data
            string result = "101";

            int pos = Raw_Data.Length == 8 ? 1 : 0;
            foreach (char c in pattern)
            {
                int i = Int32.Parse(Raw_Data[pos++].ToString());
                if (c == 'a')
                {
                    result += EAN_CodeA[i];
                }//if
                else if (c == 'b')
                {
                    result += EAN_CodeB[i];
                }//else if
            }//foreach

            //guard bars
            result += "01010";

            //end bars
            result += "1";

            return result;
        }//Encode_UPCE

        private string UpcE6ToUpcE8(string article)
        {
            if (article.Length != 6)
                throw new Exception("UPC-E6 can be only 6 symbols long");
            var upcA = UpcE6ToUpcA(article);
            return '0' + article + upcA[11];
        }

        private string UpcE6ToUpcA(string article)
        {
            if (article.Length != 6)
                throw new Exception("UPC-E6 can be only 6 symbols long");

            var lastDigit = article[5];
            string barcode11D;
            switch (lastDigit)
            {
                case '0':
                case '1':
                case '2':
                    barcode11D = '0' + article.Substring(0, 2) + lastDigit + "0000" + article.Substring(2, 3);
                    return barcode11D + GetUpcACheckDigit(barcode11D);
                case '3':
                    barcode11D = '0' + article.Substring(0, 3) + "00000" + article.Substring(3, 2);
                    return barcode11D + GetUpcACheckDigit(barcode11D);
                case '4':
                    barcode11D = '0' + article.Substring(0, 4) + "00000" + article.Substring(4, 1);
                    return barcode11D + GetUpcACheckDigit(barcode11D);
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    barcode11D = '0' + article.Substring(0, 5) + "0000" + lastDigit;
                    return barcode11D + GetUpcACheckDigit(barcode11D);
                default:
                    throw new Exception("Unexpected digit found");
            }
        }

        public static char GetUpcACheckDigit(string article)
        {
            if (article.Length != 11)
                throw new Exception("UPC-A can be only 11 symbols long to get check digit");
            int odd = (article[0] + article[2] + article[4] + article[6] + article[8] + article[10] - '0' * 6) * 3;
            int even = article[1] + article[3] + article[5] + article[7] + article[9] - '0' * 5;
            int check = (10 - ((odd + even) % 10)) % 10;
            return (char)(check + '0');
        }

        #region IBarcode Members

        public string Encoded_Value
        {
            get { return Encode_UPCE(); }
        }

        #endregion
    }
}
