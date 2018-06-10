import java.util.Scanner;

public class TaskId002 {
    public static void main(String[] args){
        System.out.print("Your name here: ");
        String UserName;
        Scanner UserNameImput = new Scanner (System.in);
        UserName = UserNameImput.nextLine();
        System.out.println("Nice to meet you!" + UserName);

    }
}
