using System;
using System.ComponentModel;

namespace ConsoleApp7
{
    public class Practice
    {
        /// <summary>
        /// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
        /// </summary>
        public static void B2_P1_1_TypeConvert()
        {
            //CONVERSION (explicit, implicit, Convert)

            //1. CHAR CONVERSION 
            char sex = 'М';//to string
            string sex1 = Convert.ToString(sex); //"M"
            Console.WriteLine("explicit sex1= " + sex1);

            Console.WriteLine("char '3' to int");
            char place = '3';//to int
            int place1 = Convert.ToInt32(place);
            int place2 = place;
            Console.WriteLine($"explicit place1 = {place1}; implicit place1 = {place2}");

            Console.WriteLine("char '0' to boolean");
            char hasFingerPrints = '0';//to boolean
            Console.WriteLine("InvalidCastException: This conversion is not supported. " + "hasFingerPrints = " + hasFingerPrints);

            //2. STRING CONVERSION           
            string hasPhotoString = "True";//to bolean
            Console.WriteLine(hasPhotoString);
            bool hasPhotoString1 = Convert.ToBoolean(hasPhotoString);
            Console.WriteLine("explicit string 'True' to boolean = " + hasPhotoString1);

            string flatNumber = "34";//to int
            Console.WriteLine("string 'flatNumber' = " + flatNumber);
            int flatNumber1 = Convert.ToInt16(flatNumber);
            int flatNumber2 = flatNumber1;
            Console.WriteLine("explicit string '34' to int = " + flatNumber1 + "; implicit string '34' to int = " + flatNumber2);

            string visaPriceString = "34,23";//to float
            float visaPriceString1 = Convert.ToSingle(visaPriceString);
            Console.WriteLine("explicit string '34,23' to float = " + visaPriceString);

            string photoPriceString = "7.23";//to float
                                             //float photoPriceString1 = Convert.ToSingle(photoPriceString);
                                             // Console.WriteLine($"explicit string '7.23' to float = {photoPriceString1}");

            //3. BOOL CONVERSION
            bool hasFree2Pages = false;//to string, to char, to int
            string hasFree2Pages1 = Convert.ToString(hasFree2Pages);
            int hasFree2Pages3 = Convert.ToInt32(hasFree2Pages);
            Console.WriteLine($"explicit bool 'false' to string = {hasFree2Pages1}; explicit bool 'false' to int = {hasFree2Pages3} ");

            //4. DECIMAL CONVERSION
            double visaPrice = 60;//to int, to string       
            int visaPrice1 = Convert.ToInt32(visaPrice);
            string visaPrice2 = Convert.ToString(visaPrice);
            Console.WriteLine($"explicit double '60' to int = {visaPrice1}; explicit double '60' to string = {visaPrice2}");

            double finterPrintsPrice = 55.2;//to int, to string
            int finterPrintsPrice1 = Convert.ToInt32(finterPrintsPrice);
            string finterPrintsPrice2 = Convert.ToString(finterPrintsPrice);
            int finterPrintsPrice3 = (int)finterPrintsPrice;
            Console.WriteLine($"explicit double '55.2' to int = {finterPrintsPrice1}, {finterPrintsPrice3}; explicit double '55.2' to string = {finterPrintsPrice2}");

            //4. INT CONVERSION
            int birthYear = 2000;//to string, to double, to char
            char birhtYear1 = (char)birthYear;
            double birhtYear2 = (double)birthYear;
            string birhtYearString = Convert.ToString(birthYear);
            double birthYearDouble = Convert.ToDouble(birthYear);
            char birthYearchar = Convert.ToChar(birthYear);
            Console.WriteLine($"explicit int '2000' to string = {birhtYearString}; explicit int '2000' to double = {birhtYear2}, {birthYearDouble}; explicit int '2000' to char = {birhtYear1}, {birthYearchar} ");


            int hasPhotoInt = 1;//to boolean
            bool hasPhotoInt2 = Convert.ToBoolean(hasPhotoInt);
            Console.WriteLine("explicit int '1' to boolean = " + hasPhotoInt2);
        }
    }
}
