Explanation:
Rectangle Class:

A Rectangle class is defined with Width, Height, and Area properties.
The Area property calculates the area of the rectangle by multiplying Width and Height.
The ToString method is overridden to provide a formatted string for easy output.
Main Method:

We generate 10 rectangles with random widths and heights using the Random class. The width and height are randomly chosen between 1 and 100.
Each rectangle is printed to the console.
The FindLargestRectangle method is called to determine the largest rectangle by area, and in case of a tie, by height.
FindLargestRectangle Method:

This method iterates over the array of rectangles and compares each one to find the largest.
If the current rectangle has a larger area than the current largest, it becomes the new largest.
If the current rectangle has the same area but a greater height, it also becomes the new largest.
Execution:

With each execution of the program, different random rectangles will be generated, and the largest one will be identified and printed.
Example Output: