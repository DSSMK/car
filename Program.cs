using day2;

NewMethod();

static void NewMethod()
{
    NewMethod1();

    static void NewMethod1()
    {
        Car car1 = new Car();

        car1.speed = 130;
        car1.color = "blue";
        car1.model = "Kia";

        Console.WriteLine(car1.speed);
        Console.WriteLine(car1.color);
        Console.WriteLine(car1.model);

        Console.WriteLine("-----------------");

        car1.print();

        Console.WriteLine("-----------------");
        Car car2 = new Car();
        car2.speed = 150;
        car2.color = "red";
        car2.model = "toyata";

        Console.WriteLine(car2.speed);
        Console.WriteLine(car2.color);
        Console.WriteLine(car2.model);
        Console.WriteLine("-----------------");

        car2.print();

        Console.WriteLine("-----------------");

        Kia kia1 = new Kia();

        kia1.op();

        Add add1 = new Add();

        add1.add(5,7);
        add1.add(6, 7, 8);

        Console.WriteLine("ruth in :" + add1.add(5,6,8));
    }
}
