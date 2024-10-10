
// See https://aka.ms/new-console-template for more information

// creating object

using Learning_DOT_NET;

//Car objCar;    //car class variable
//objCar=new Car();   // objCar is now object

//Car objCar = new Car();
//objCar.Name = "honda city";
//objCar.Noofseats = 4;
//objCar.Brand = "honda";
//objCar.color = "black";

//objCar.Accelerator(10);
//objCar.brake(100);


//Car objCar2 = new Car();
//objCar2.Name = "i10";
//objCar2.Noofseats = 6;
//objCar2.Brand = "hyundai";
//objCar2.color = "red";

//objCar2.Accelerator(20);
//objCar2.brake(100);


//Car objCar3 = new Car();

//objCar3 = objCar;              // data members and member function of objCar3 becomes same as objCar
////objCar=null;          // yeh kisi ko represent nahi karega


//Console.WriteLine("---------------------------------------------------------------");
//Console.WriteLine(objCar3.Noofseats); //4
//Console.WriteLine(objCar.Noofseats); // no value  // jab tak heap se value delete nahi karoge yaha pe value dikhti rahegi
//Console.ReadLine();







/*-----------------------Class 4  Methods and constructor------------------------*/


//MathsOperation objMO=new MathsOperation();

//objMO.Sum(10, 20);
//int m,n;                                      // m will store the value
//m = objMO.Sum(50, 40); 
//Console.WriteLine("the value of m will be "+m);


// to call array  // method with array
//int[] array1 = new int[] { 1, 2, 3, 5 ,6};
//int result1 = objMO.sum(array1);
//Console.WriteLine(result1);


//  return type of array

//int[] resultArray = objMO.Arrayfromno(10,20,30);  // here array is returning


// for unlimited
// by using params array

//int result = objMO.Add(24, 54, 45, 28, 69, 78, 98, 96, 95);
//Console.WriteLine("the result is "+result);



/*---------------------------------Constructor Examples-------------------------------------------------------*/

// to get default values we use constructor

//ConstructorExample objExample=new ConstructorExample();
//ConstructorExample objExample = new ConstructorExample(100,"sanket");
//Console.WriteLine(objExample.varInt);
//Console.WriteLine(objExample.varString);



/*copy constructor*/

//ConstructorExample objConst2 = new ConstructorExample(objExample);










/*------------------------------ Class 5 - Static Constructor in C# ------------------------------------*/


//StaticExample objSE = new StaticExample();
//objSE.varint = 10;

//StaticExample objSE2 = new StaticExample();
//objSE2.varint = 20;

// we can access static variable by using name of the class or with class

//StaticExample.StaticVarInt = 30; 
//StaticExample.TestMethod();


/* -------------------  How to call static constructor----------------------  */

//ConstructorExample objce = new ConstructorExample();  // when this object will create at that time static constructor takes place
//ConstructorExample objce2 = new ConstructorExample();

//Console.ReadLine();






/*------------------------------ Class 6 - Properties and Inheritance basics in C# ------------------------------------*/


//PropertiesExample obj = new PropertiesExample();
//obj.size = 20;     // set
//obj.Testprop = 50;  // set
//Console.WriteLine(obj.size);  //Get
//Console.WriteLine(obj.Testprop);  //Get

// Read only properties :- // here we cannot set value because we apply private modifier to  ( Set )
//  obj.MyProperty = 50;
// Write only properties :- // we can set the property but cannot read
//obj.writeonprop = 99;
/*Console.WriteLine(obj.writeonprop);*/  // we cannot see this



/*==============================Inheritance===========================*/


/*Parent objparent = new Parent();  // it cannot access child
objparent.Parentmethod();

Child objchild = new Child();  // it can access both child itself and parent also
objchild.Parentmethod();
objchild.Childmethod();


Console.ReadLine();*/




/*------------------------------ Class 7 -  Inheritance types C# ------------------------------------*/


//Child objchild = new Child();
//objchild.ParentMethod2();
//objchild.Parentmethod(); // go for its own class or child class not for parent  // it gives priority to its child class



//Parent parent = new Child(); // here parent class can save the objects of child class
//parent.Parentmethod();  // it gives priority to its parent class





/*------------------------------ Class 8 -  Interface in C# ------------------------------------*/

// Abstraction : to show only that is necessary and hide the details of implementation.(ander ke process se koi matlab nahi)


//Class1 objclass1 = new Class1();


//iTest objclass2 = new Class1();

//iTest2 objclass3 = new Class1();

//Parentclass objclass4 = new Class1(); // onlu parent class can acccess its own methods ,it cannot access outer class members or methods.




/*------------------------------ Class 9 -  Collection in C# ------------------------------------*/



//CollectionExamles col=new CollectionExamles();
//col.ArrayListCollection();



/*------------------------------ Class 10 - Generic Collection in C# ------------------------------------*/



/*------------------------------ Class 11 - Exception Handling in C# ------------------------------------*/


ExceptionHandling objEH = new ExceptionHandling();
objEH.TestMethod(5);


Console.ReadLine();