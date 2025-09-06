double? M = 0;
double? num_1 = null;
double? num_2 = null;
double? res = null;
string? oper = null;
double? last = 0;
while (true)
{
    string? err = null;
    switch (oper)
    {
        case "M+":
            M += last;
            oper = null;
            break;
        case "M-":
            M -= last;
            oper = null;
            break;
        case "MR":
            res = M;
            goto case "print";
        case "+":
            if (num_2 == null)
            {
                break;
            }
            res = num_1 + num_2;
            goto case "print";
        case "-":
            if (num_2 == null)
            {
                break;
            }
            res = num_1 - num_2;
            goto case "print";
        case "*":
            if (num_2 == null)
            {
                break;
            }
            res = num_1 * num_2;
            goto case "print";
        case "/":
            if (num_2 == null)
            {
                break;
            }
            if (num_2 == 0)
            {
                err = "Делить на 0 нельзя!";
                goto case "err";
            }
            res = num_1 / num_2;
            goto case "print";
        case "%":
            if (num_2 == null)
            {
                break;
            }
            if (num_2 == 0)
            {
                err = "Делить на 0 нельзя!";
                goto case "err";
            }
            res = num_1 % num_2;
            goto case "print";
        case "1/x":
            if (num_1 == null)
            {
                break;
            }
            if (num_1 == 0)
            {
                err = "Делить на 0 нельзя!";
                goto case "err";
            }
            res = 1 / num_1;
            goto case "print";
        case "sqrt":
            if (num_1 == null)
            {
                break;
            }
            if (num_1 < 0)
            {
                err = "Извлечь корень из отрицательного числа нельзя!";
                goto case "err";
            }
            res = Math.Sqrt(Convert.ToDouble(num_1));
            goto case "print";
        case "^2":
            if (num_1 == null)
            {
                break;
            }
            res = num_1 * num_1;
            goto case "print";
        case "print":
            if (oper == "print")
            {
                err = "Недопустимая операция!";
                goto case "err";
            }
            Console.WriteLine($"Результат: {res}\n");
            last = res;
            num_1 = null;
            num_2 = null;
            oper = null;
            break;
        case "err":
            if (oper == "err")
            {
                err = "Недопустимая операция!";
            }
            Console.WriteLine($"Ошибка! {err}");
            break;
        case null:
            break;
        default:
            err = "Недопустимая операция!";
            goto case "err";
    }
    if (num_1 != null && num_2 != null)
    {
        Console.WriteLine("Введите Операцию:\n");
        oper = Console.ReadLine();
    } else
    {
        Console.WriteLine("Введите число или операцию:\n");
        string tmp = Console.ReadLine();
        try
        {
            if (num_1 == null)
            {
                num_1 = Convert.ToDouble(tmp);
            }
            else
            {
                num_2 = Convert.ToDouble(tmp);
            }
            last = Convert.ToDouble(tmp);
        }
        catch
        {
            oper = tmp;
        }
    }  
    
   
    Console.Clear();
}

