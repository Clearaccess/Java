import java.util.*;
import java.io.*;

/**
 * Created by Aleksandr on 10.03.2016.
 */
public class Solution {

    public void clearConsole() {


        for (int i = 0; i < 100; i++) {
            System.out.println();
        }
    }

    public static void main(String[] argv) throws IOException, DAOFormatException, MenuNullException, ClassNotFoundException, DAORemoveException {
        Solution app = new Solution();
        app.startApplication();
    }

    public void startApplication() throws IOException, DAOFormatException, MenuNullException, ClassNotFoundException, DAORemoveException {
        ReportsService rep = new ReportsService();
        BLL query = new BLL();

        while (true) {
            clearConsole();
            System.out.println("Нажмите: ");
            System.out.println("0: Для выхода из приложения");
            System.out.println("1: Для выхода первого отчета");
            System.out.println("2: Для выхода второго отчета");
            System.out.println("3: Для добавления блюда");
            System.out.println("4: Для удаления блюда");
            System.out.println("5: Для добавления заказа");
            System.out.println("6: Для удаления заказа");

            BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
            StringTokenizer st = new StringTokenizer(in.readLine());
            int command = Integer.parseInt(st.nextToken());

            if (command == 0) {
                System.exit(0);
            }
            if (command == 1) {
                try {
                    rep.printReport1();
                }
                catch(MenuNullException e){
                }
                System.out.println("Для продолжения нажмите enter");
                System.in.read();
            }
            if (command == 2) {
                try {
                    rep.printReport2();
                }
                catch (MenuNullException e){

                }
                System.out.println("Для продолжения нажмите enter");
                System.in.read();
            }
            if (command == 3) {
                clearConsole();
                System.out.println("Введите название блюда, вес, цена");
                BufferedReader in2 = new BufferedReader(new InputStreamReader(System.in));
                StringTokenizer st2 = new StringTokenizer(in.readLine());
                String name=st2.nextToken();
                Double weight= Double.parseDouble(st2.nextToken());
                Double price= Double.parseDouble(st2.nextToken());
                query.addDish(name,new Dish(weight,price));
                System.out.println("Для продолжения нажмите enter");
                System.in.read();
            }
            if (command == 4) {
                clearConsole();
                System.out.println("Введите название блюда");
                BufferedReader in2 = new BufferedReader(new InputStreamReader(System.in));
                StringTokenizer st2 = new StringTokenizer(in.readLine());
                String name=st2.nextToken();
                query.removeDish(name);
                System.out.println("Для продолжения нажмите enter");
                System.in.read();
            }
            if(command==5){
                clearConsole();
                System.out.println("Введите имя заказчика и заказ (название блюда, количество)");
                BufferedReader in2 = new BufferedReader(new InputStreamReader(System.in));
                StringTokenizer st2 = new StringTokenizer(in.readLine());
                String name=st2.nextToken();
                HashMap<String,Integer>order=new HashMap<String,Integer>();
                while(st2.hasMoreTokens()){
                    String nameDish=st2.nextToken();
                    Integer countDish=Integer.parseInt(st2.nextToken());
                    order.put(nameDish,countDish);
                }
                query.addOrder(name,new Order(order));
                System.out.println("Для продолжения нажмите enter");
                System.in.read();
            }
            if(command==6){
                clearConsole();
                System.out.println("Введите имя заказчика");
                BufferedReader in2 = new BufferedReader(new InputStreamReader(System.in));
                StringTokenizer st2 = new StringTokenizer(in.readLine());
                String name=st2.nextToken();
                query.removeOrder(name);
                System.out.println("Для продолжения нажмите enter");
                System.in.read();
            }
        }
    }
}
