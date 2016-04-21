import java.io.*;
import java.util.*;

/**
 * Created by Aleksandr on 4/14/2016.
 */
public class DAO {

    static ArrayList<Employee> employees=new ArrayList<Employee>(0);
    static Menu menu=new Menu();

    public DAO() throws IOException {
        menu=readMenu();
        employees=readOrder();
    }

    private Menu readMenu() throws FileNotFoundException, IOException {
        HashMap<String, Dish> dishes=new HashMap<String,Dish>(0);
        BufferedReader inMenu = new BufferedReader(new FileReader("C:\\Users\\Aleksandr\\IdeaProjects\\Solution2\\src\\menu"));
        String s;
        inMenu.readLine();
        String name = null;
        Double weight=null;
        Double price=null;

        while ((s = inMenu.readLine()) != null) {
            StringTokenizer col = new StringTokenizer(s, "|");
            int ind = 0;
            while (col.hasMoreTokens()) {
                if (ind == 0) {
                    name = col.nextToken().trim();
                } else {
                    StringTokenizer st = new StringTokenizer(col.nextToken());
                    if (ind == 1) {
                        weight=Double.parseDouble(st.nextToken().trim());
                    }
                    else {
                        price=Double.parseDouble(st.nextToken().trim());
                    }
                }
                ind++;
            }
            dishes.put(name,new Dish(weight,price));
        }

        return new Menu(dishes);
    }

    private ArrayList<Employee> readOrder() throws FileNotFoundException, IOException{
        BufferedReader inOrder =new BufferedReader(new FileReader("C:\\Users\\Aleksandr\\IdeaProjects\\Solution2\\src\\order"));
        String s;
        //inOrder.readLine();
        ArrayList<Employee> employees=new ArrayList<Employee>(0);

        while ((s = inOrder.readLine()) != null) {
            StringTokenizer col = new StringTokenizer(s, "|");
            int ind = 0;
            HashMap<String, Integer> dishes=new HashMap<String, Integer>(0);
            String nameEmployee = null;

            while (col.hasMoreTokens()) {
                if (ind == 0) {
                    nameEmployee=(col.nextToken().trim());
                } else {
                    StringTokenizer st = new StringTokenizer(col.nextToken(),",");
                    while(st.hasMoreTokens()){
                        String nameDish=st.nextToken().trim();
                        if (!dishes.containsKey(nameDish)) {
                            dishes.put(nameDish, 1);
                        } else {
                            dishes.replace(nameDish, dishes.get(nameDish) + 1);
                        }
                    }
                }
                ind++;
            }
            employees.add(new Employee(nameEmployee, new Order(dishes)));
        }

        return employees;
    }

    public ArrayList<Employee> getEmployees(){
        return employees;
    }

    public Menu getMenu(){
        return menu;
    }

}
