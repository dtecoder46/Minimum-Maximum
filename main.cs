using System;

class Program {
  public static void Main (string[] args) {

    Console.WriteLine("\nDownload the pdf file in this project to see the documentation\n");
    
    Console.WriteLine("How many numbers do you want to put in?:");
    int item_num = Convert.ToInt32(Console.ReadLine());

    // Creates an empty array with the amount of array items determined by the user
    
    int[] array = new int[item_num];

    for (int counter = 0; counter < item_num; counter++) {
      Console.WriteLine("\nNumber:");
      int array_item = Convert.ToInt32(Console.ReadLine());
      array[counter] = array_item;
    }

    int largest = 0;
    int smallest = array[0]; // cannot be initialzed to 0 in case none of the array numbers are smaller than 0

    /* The for loops the array to find the largest/smallest number by comparing each item with a set number, which can become the new comparison number if it is larger/smaller than the previous */

    // Max module
    
    for (int counter = 0; counter < array.Length; counter++) {
    
      if (array[counter] > largest) {
        largest = array[counter];
      }
    }

    // Min module
    
    for (int counter = 0; counter < array.Length; counter++) {

      if (array[counter] < smallest) {
        smallest = array[counter];
      }
    }

    Console.WriteLine("\nThe maximum number is " + largest);
    Console.WriteLine("The minimum number is " + smallest);

  }
}