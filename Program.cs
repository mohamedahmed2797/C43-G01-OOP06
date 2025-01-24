namespace C43_G01_OOP06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project:
            //int x, y, z, a, b, c;
            //while (true)
            //{
            //    Console.Write("P1.1 : ");
            //    if (int.TryParse(Console.ReadLine(), out  x))
            //    {
            //        {
            //            break;
            //        }
            //    }

            //    else
            //        Console.WriteLine("please enter an valid number");

            //}

            //while (true)
            //{
            //    Console.Write("P1.2 : ");
            //    if (int.TryParse(Console.ReadLine(), out y))
            //    {
            //        {
            //            break;
            //        }
            //    }
            //    else
            //        Console.WriteLine("please enter an valid number");

            //}
            //while (true)
            //{
            //    Console.Write("P1.3 : ");
            //    if (int.TryParse(Console.ReadLine(), out z))
            //    {
            //        {
            //            break;
            //        }
            //    }
            //    else
            //        Console.WriteLine("please enter an valid number");

            //}

            //Point3D P1 = new Point3D(x, y, z);

            //while (true)
            //{
            //    Console.Write("\nP2.1 : ");
            //    if (int.TryParse(Console.ReadLine(), out a))
            //    {
            //        {
            //            break;
            //        }
            //    }
            //    else
            //        Console.WriteLine("please enter an valid number");

            //}
            //while (true)
            //{
            //    Console.Write("P2.2 : ");
            //    if (int.TryParse(Console.ReadLine(), out b))
            //    {
            //        {
            //            break;
            //        }
            //    }
            //    else
            //        Console.WriteLine("please enter an valid number");

            //}
            //while (true)
            //{
            //    Console.Write("P2.3 : ");
            //    if (int.TryParse(Console.ReadLine(), out c))
            //    {
            //        {
            //            break;
            //        }
            //    }
            //    else
            //        Console.WriteLine("please enter an valid number");

            //}
            //Point3D P2 = new Point3D(a, b, c);
            //Console.Clear();
            //Console.WriteLine(P1.ToString());
            //Console.WriteLine(P2.ToString());

            //if (P1 == P2)
            //{
            //    Console.WriteLine("P1 and P2 are the same point.");
            //}
            //else
            //{
            //    Console.WriteLine("P1 and P2 are different points.");
            //}
            //Point3D P1Clone = (Point3D)P1.Clone();
            //Point3D P2Clone = (Point3D)P2.Clone();

            //Point3D[] point = new Point3D[] { P1Clone, P2Clone };

            //Console.WriteLine("before sorting");
            //foreach (Point3D p in point)
            //{
            //    Console.WriteLine(p);
            //}
            //Array.Sort(point,(P1 , P2) =>
            //{
            //    int CX = P1.X.CompareTo(P2.X);
            //    if (CX == 0)
            //    {
            //        return P1.Y.CompareTo(P2.Y);
            //    }

            //    return CX;
            //}
            //);
            //Console.WriteLine("after sorting");

            //foreach (Point3D p in point)
            //{
            //    Console.WriteLine(p);
            //}

            #endregion
            #region Second Project:

            //double n1 = 12.5;
            //double n2 = 13.5;
            //Console.WriteLine($"n1 = {n1}");
            //Console.WriteLine($"n2 = {n2}");
            //Console.WriteLine($"Add : {n1} + {n2}  = {Maths.Add(n1, n2)}");
            //Console.WriteLine($"Subtract : {n1} - {n2}  = {Maths.Subtract(n1, n2)}");
            //Console.WriteLine($"Multiply : {n1} * {n2}  = {Maths.Multiply(n1, n2)}");
            //Console.WriteLine($"Divide : {n1} / {n2}  = {Maths.Divide(n1, n2)}");

            #endregion
            #region Third Project:

            //Console.WriteLine("Enter your user type (Regular, Premium, Guest):");
            //string userType = Console.ReadLine().Trim().ToLower();
            //User user;
            //switch (userType)
            //{
            //    case "regular":
            //        Console.WriteLine("Enter your name:");
            //        string regularName = Console.ReadLine();
            //        user = new RegularUser(regularName);
            //        break;
            //    case "premium":
            //        Console.WriteLine("Enter your name:");
            //        string premiumName = Console.ReadLine();
            //        user = new PremiumUser(premiumName);
            //        break;
            //    case "guest":
            //        Console.WriteLine("Enter your name:");
            //        string guestName = Console.ReadLine();
            //        user = new GuestUser(guestName);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid user type");
            //        return;
            //}
            //Console.WriteLine("Enter the product price:");
            //decimal price;
            //while (!decimal.TryParse(Console.ReadLine(), out price) || price <= 0)
            //{
            //    Console.WriteLine("Please enter a valid price.");
            //}
            //Console.WriteLine("Enter the quantity:");
            //int quantity;
            //while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
            //{
            //    Console.WriteLine("Please enter a valid  quantity.");
            //}
            //Discount userDiscount = user.GetDiscount();
            //decimal discountAmount = 0;
            //if (userDiscount != null)
            //{
            //    discountAmount = userDiscount.CalculateDiscount(price, quantity);
            //}
            //Console.Clear();
            //decimal totalPrice = price * quantity;
            //decimal PriceAfterDis = totalPrice - discountAmount;
            //Console.WriteLine($"Product Price: ${price}");
            //Console.WriteLine($"Quantity: {quantity}");
            //Console.WriteLine($"Total Price before discount: ${totalPrice}");
            //if (userDiscount != null)
            //{
            //    Console.WriteLine($"Discount ({userDiscount.Name}): -${discountAmount}");
            //}
            //Console.WriteLine($" Price after discount: ${PriceAfterDis}");
          

            #endregion

        }
    }
}
