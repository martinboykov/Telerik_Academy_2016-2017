using System;

class XExpression
{
    static void Main()
    {
        string expression = "4+6/5+(4*9–8)/7*2=";
        char[] array = expression.ToCharArray();
        int number1, number2;
        int product = 0;
        int productBraces = 0;
        char sign;

        number1 = Convert.ToInt32(array[0] - '0');
        sign = array[1];
        number2 = Convert.ToInt32(array[2] - '0');
        product = number1 + number2;
        for (int i = 3; i < array.Length; i++)
        {
            switch (array[i])
            {
                //if Integer
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    {
                        if (array[i + 1] != '(')
                        {
                            switch (array[i + 1])
                            {
                                case '1':
                                case '2':
                                case '3':
                                case '4':
                                case '5':
                                case '6':
                                case '7':
                                case '8':
                                case '9':
                                    {
                                        number1 = Convert.ToInt32(array[i] - '0');
                                        sign = array[i + 1];
                                        number2 = Convert.ToInt32(array[i + 2] - '0');
                                        product = number1 + number2;
                                        i = i + 2;
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            goto case '(';
                        }
                    }
                    break;

                //if sign
                case '+':
                case '-':
                case '–':
                case '*':
                case '/':
                    {
                        if (array[i + 1] != '(')
                        {
                            switch (array[i + 1])
                            {
                                case '1':
                                case '2':
                                case '3':
                                case '4':
                                case '5':
                                case '6':
                                case '7':
                                case '8':
                                case '9':
                                    {
                                        sign = array[i + 1];
                                        number2 = Convert.ToInt32(array[i + 2] - '0');
                                        switch (sign)
                                        {
                                            case '+': product = product + number2; break;
                                            case '-': product = product - number2; break;
                                            case '–': product = product - number2; break;
                                            case '*': product = product * number2; break;
                                            case '/': product = product / number2; break;
                                        }
                                        i = i + 2;
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            goto case '(';
                        }
                    }
                    break;

                //if brace '('
                case '(':
                    {
                        number1 = Convert.ToInt32(array[i+1] - '0');
                        sign = array[i + 2];
                        number2 = Convert.ToInt32(array[i + 3] - '0');
                        switch (sign)
                        {
                            case '+': productBraces = number1 + number2; break;
                            case '-': productBraces = number1 - number2; break;
                            case '–': productBraces = number1 - number2; break;
                            case '*': productBraces = number1 * number2; break;
                            case '/': productBraces = number1 / number2; break;
                        }
                        i = i + 4;

                        //start cycle in the Braces 
                        while (array[i] != ')')
                        {
                            sign = array[i + 1];
                            number2 = Convert.ToInt32(array[i + 2] - '0');
                            switch (sign)
                            {
                                case '+': productBraces = productBraces + number2; break;
                                case '-': productBraces = productBraces - number2; break;
                                case '–': productBraces = productBraces - number2; break;
                                case '*': productBraces = productBraces * number2; break;
                                case '/': productBraces = productBraces / number2; break;
                                    
                            }
                            i = i + 3;
                        }
                    }
                    break;
            }
        }
    }
}