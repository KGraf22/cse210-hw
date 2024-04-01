using System;
using Microsoft.VisualBasic.FileIO;
class Program
{
    static void Main(string[] args)
    {
        string customersListFilePath = "customers-list.csv";
        string customerSalesFilePath = "customer_sales.csv";

        ReadCSV(customersListFilePath);

        ReadCSV(customerSalesFilePath);
    }

    static void ReadCSV (string filePath)
    {

    }
}