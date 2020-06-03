
package carpooling_package;

import java.util.ArrayList;
import java.util.Scanner;


public class CarPooling {

    public static ArrayList<Passenger> passengers_array = new ArrayList<Passenger>();
    public ArrayList<Car> cars_array = new ArrayList<Car>();
    public static Scanner sc = new Scanner(System.in);
    private static int choice_Home, choice_endOfStep;
    
    public static void main(String[] args) {
        
        intialize();
        chooseFromHomePage();
        
    }
    
    public static void intialize(){
        System.out.println("----------------------------------------------------\n"
                + "Welcome, Our Dear Client\n\nSelect the operation that you want by choosing the number of the process");
        System.out.println("[1] "+"Subscribe\n"+"[2] "+"Un-Subscribe\n"+"[3] "+"Search for Route\n"+"[4] "+"Reserve a Ticket\n"+"[5] "+"Report Review\n\n");
        System.out.print("Your choice : ");  choice_Home = sc.nextInt();
    }
    
    public static void chooseFromHomePage(){
        if(choice_Home == 1){
            Process prosess_obj=new Process(1); 
        }else if(choice_Home == 2){
            Process prosess_obj=new Process(2);
        }
          
    }
    
    public static void endOfStep(){
        System.out.println("If You want to return to Menu choose [1]\nIf You want to exit choose[2]");
        choice_endOfStep= sc.nextInt();
        if(choice_endOfStep==1){
            intialize();
            chooseFromHomePage();
        } 
        else 
            System.exit(0);
    }
    
}

class Process { 

    private int choice;
    
    public Process(int choice) {
        this.choice=choice;
        start();
    }
    
    void start(){
        if(choice==1){
            Passenger passenger_obj = new Subsciber();
        }else if(choice==2){
            Passenger passenger_obj = new Non_Subsciber();
        }
        
        CarPooling.endOfStep();
    }
}

interface passenger_interface {
    
    public void enterName();
    public void enterAge();
    
}

abstract class Passenger implements passenger_interface{

    final int Alowed_age = 20;
    String passenger_name;
    int passenger_age;
    boolean isSubscriber=false;
    Passenger() { }
    
}
       
class Subsciber extends Passenger {
    
    
    Subsciber(){
        enterName();
        enterAge();
        checkAge();
    }

    @Override
    public void enterName() {
        System.out.print("Please, Enter your name:  ");
        passenger_name = CarPooling.sc.next();
    }

    @Override
    public void enterAge() { 
        System.out.print("Please, Enter your age:  ");
        passenger_age  = CarPooling.sc.nextInt();
    }
    
    void checkAge(){
        if(passenger_age>=Alowed_age){
            System.out.println("\nCongratulation - You've subscribed successfully\n");
            isSubscriber = true;
            CarPooling.passengers_array.add(this);
        }else{
            System.out.println("\nSorry your age isn't allowed in subscribtion, So you're not subscribed\n");
            Passenger passenger_obj = new Non_Subsciber(passenger_name, passenger_age);
        }
    }
   
}

class Non_Subsciber extends Passenger {
    
    Non_Subsciber(){
        isSubscriber=false;
        enterName();
        enterAge();
        CarPooling.passengers_array.add(this);
        System.out.println("\nYou're now a Non-Subsciber User\n");
    }
    
    Non_Subsciber(String name, int age){
        this.passenger_name=passenger_name;
        this.passenger_age=passenger_age;
        this.isSubscriber=false;
        CarPooling.passengers_array.add(this);
    }
    
    @Override
    public void enterName() {
        System.out.print("Please, Enter your name:  ");
        passenger_name = CarPooling.sc.next();
    }

    @Override
    public void enterAge() {
        System.out.print("Please, Enter your age:  ");
        passenger_age = CarPooling.sc.nextInt();
    }
    
}

class Car {
    
    Car(){}
}

class Ticket{

    public Ticket() {
    }
    
}