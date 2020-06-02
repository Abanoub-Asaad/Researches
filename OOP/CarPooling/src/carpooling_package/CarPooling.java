
package carpooling_package;

import java.util.ArrayList;
import java.util.Scanner;


public class CarPooling {

    public static ArrayList<Passenger> passengers_array = new ArrayList<Passenger>();
    public ArrayList<Car> cars_array = new ArrayList<Car>();
    public static Scanner sc = new Scanner(System.in);
    
    public static void main(String[] args) {
        
        System.out.println("Welcome, Our Dear Client\n\nSelect the operation that you want by choosing the number of the process\n");
        System.out.println("[1] "+"Subscribe\n"+"[2] "+"Un-Subscribe\n"+"[3] "+"Search for Route\n"+"[4] "+"Reserve a Ticket\n"+"[5] "+"Report Review\n\n");
        System.out.println("Your choice : "); int choice = sc.nextInt();
        
        if(choice == 1){
            Process prosess_obj=new Process(1);
        }
            
        
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
        }
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
        System.out.println("Please, Enter your name:\n");
        passenger_name = CarPooling.sc.next();
    }

    @Override
    public void enterAge() { 
        System.out.println("Please, Enter your age:\n");
        passenger_age  = CarPooling.sc.nextInt();
    }
    
    void checkAge(){
        if(passenger_age>=Alowed_age){
            System.out.println("Congratulation - You've subscribed successfully\n");
            isSubscriber = true;
            CarPooling.passengers_array.add(this);
        }else{
            System.out.println("Sorry your age isn't allowed in subscribtion, So you're not subscribed\n");
            Passenger passenger_obj = new Non_Subsciber(passenger_name, passenger_age);
        }
    }
   
}

class Non_Subsciber extends Passenger {
    
    Non_Subsciber(){}
    Non_Subsciber(String name, int age){
        this.passenger_name=passenger_name;
        this.passenger_age=passenger_age;
        this.isSubscriber=false;
        CarPooling.passengers_array.add(this);
    }
    
    @Override
    public void enterName() {}

    @Override
    public void enterAge() {}
    
}

class Car {
    
    Car(){}
}

class Ticket{

    public Ticket() {
    }
    
}