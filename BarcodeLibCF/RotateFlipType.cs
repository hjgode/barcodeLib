using System;
namespace System.Drawing
{
    // Summary:
    //     Specifies the direction of an image's rotation and the axis used to flip
    //     the image.
    public enum RotateFlipType
    {
        // Summary:
        //     Specifies a 180-degree rotation followed by a horizontal and vertical flip.
        Rotate180FlipXY = 0,
        //
        // Summary:
        //     Specifies no rotation and no flipping.
        RotateNoneFlipNone = 0,
        //
        // Summary:
        //     Specifies a 270-degree rotation followed by a horizontal and vertical flip.
        Rotate270FlipXY = 1,
        //
        // Summary:
        //     Specifies a 90-degree rotation without flipping.
        Rotate90FlipNone = 1,
        //
        // Summary:
        //     Specifies a 180-degree rotation without flipping.
        Rotate180FlipNone = 2,
        //
        // Summary:
        //     Specifies no rotation followed by a horizontal and vertical flip.
        RotateNoneFlipXY = 2,
        //
        // Summary:
        //     Specifies a 270-degree rotation without flipping.
        Rotate270FlipNone = 3,
        //
        // Summary:
        //     Specifies a 90-degree rotation followed by a horizontal and vertical flip.
        Rotate90FlipXY = 3,
        //
        // Summary:
        //     Specifies a 180-degree rotation followed by a vertical flip.
        Rotate180FlipY = 4,
        //
        // Summary:
        //     Specifies no rotation followed by a horizontal flip.
        RotateNoneFlipX = 4,
        //
        // Summary:
        //     Specifies a 90-degree rotation followed by a horizontal flip.
        Rotate90FlipX = 5,
        //
        // Summary:
        //     Specifies a 270-degree rotation followed by a vertical flip.
        Rotate270FlipY = 5,
        //
        // Summary:
        //     Specifies no rotation followed by a vertical flip.
        RotateNoneFlipY = 6,
        //
        // Summary:
        //     Specifies a 180-degree rotation followed by a horizontal flip.
        Rotate180FlipX = 6,
        //
        // Summary:
        //     Specifies a 90-degree rotation followed by a vertical flip.
        Rotate90FlipY = 7,
        //
        // Summary:
        //     Specifies a 270-degree rotation followed by a horizontal flip.
        Rotate270FlipX = 7,
    }
}
