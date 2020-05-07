# Image Timestamper
A simple Windows Forms C# program for timestamping images.

## Features

It includes options for color, font size and timestamp offset. Automatic scaling option is also available if images vary in pixel count (though it may not work perfectly).

This timestamper derives a timestamp from metadata datetime. If metadata is not present, it tries to concatenate a timestamp from splitting the filename. Filename must be in format: **IMG_YYYYMMDD_hhmmss.xyz**

Two examples are included: one with correct metadata (**"Metadata example.jpg"**) and one with no metadata, but a valid name (**"IMG_20200102_123456.jpg"**) for timestamp extraction.

## Usage

Set desired values in input boxes (or leave them as they are, they work!) and choose your folder with images by pressing *Select folder*. Afterwards click *Timestamp images* and that's it!
