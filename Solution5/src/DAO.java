import java.io.*;
import java.util.*;

/**
 * Created by Aleksandr on 4/14/2016.
 */
public class DAO {

    //static ArrayList<Employee> employees=new ArrayList<Employee>();
    //static Menu menu=new Menu();
    static boolean state=false;
    Connecter connect=new Connecter();

    public DAO() throws IOException, DAOFormatException, MenuNullException {
        if(!state) {
            //readMenu();
            //readOrder();
            state=true;
        }
    }

    private void readMenu() throws FileNotFoundException, IOException, DAOFormatException, MenuNullException  {
        HashMap<String, Dish> dishes=new HashMap<String,Dish>();
        BufferedReader inMenu = new BufferedReader(new FileReader("D:\\Универ\\6 семестр\\Java\\Solution5\\src\\menu"));
        String s;
        inMenu.readLine();
        String name = null;
        Double weight=null;
        Double price=null;

        while ((s = inMenu.readLine()) != null) {
            StringTokenizer col = new StringTokenizer(s, "|");

            if(col.countTokens()!=3){
                throw new DAOFormatException();
            }

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
        connect.serializationMenu(new Menu(dishes));
    }

    private void readOrder() throws FileNotFoundException, IOException, DAOFormatException{
        BufferedReader inOrder =new BufferedReader(new FileReader("D:\\Универ\\6 семестр\\Java\\Solution5\\src\\order"));
        String s;

        ArrayList<Employee> employees=new ArrayList<Employee>();

        while ((s = inOrder.readLine()) != null) {
            StringTokenizer col = new StringTokenizer(s, "|");

            if(col.countTokens()!=2){
                throw new DAOFormatException();
            }

            int ind = 0;
            HashMap<String, Integer> dishes=new HashMap<String, Integer>();
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
        connect.serializationEmployees(employees);
    }

    public ArrayList<Employee> getEmployees() throws IOException, ClassNotFoundException {
        return connect.deserializationEmployees();
    }

    public Menu getMenu() throws IOException, ClassNotFoundException {
        return connect.deserializationMenu();
    }

    public void addOrder(String nameEmployee, Order infOrder) throws IOException, ClassNotFoundException {
        Employee emp=new Employee(nameEmployee,infOrder);
        ArrayList<Employee>employees=connect.deserializationEmployees();
        employees.add(emp);
        connect.serializationEmployees(employees);
    }

    public void removeOrder(String nameEmployee) throws IOException, ClassNotFoundException {
        ArrayList<Employee>employees=connect.deserializationEmployees();
        for(Employee i: employees){
            if(i.name==nameEmployee){
                employees.remove(i);
            }
        }
        connect.serializationEmployees(employees);
    }

    public void addDish(String nameDish, Dish infDish) throws IOException, ClassNotFoundException, MenuNullException {
        HashMap<String,Dish> dishes=connect.deserializationMenu().getDishes();
        dishes.put(nameDish,infDish);
        connect.serializationMenu(new Menu(dishes));
    }

    public void removeDish(String nameDish) throws IOException, ClassNotFoundException, MenuNullException, DAORemoveException {
        HashMap<String,Dish> dishes=connect.deserializationMenu().getDishes();
        if(IsDishOrder(nameDish)) {
            throw new DAORemoveException();
        }
        dishes.remove(nameDish);
        connect.serializationMenu(new Menu(dishes));
    }

    private boolean IsDishOrder(String nameDish) throws IOException, ClassNotFoundException {
        ArrayList<Employee>employees=connect.deserializationEmployees();
        for(Employee i: employees){
            for(String j: i.getOrder().getDishes().keySet()){
                if(j.equals(nameDish)){
                    return true;
                }
            }
        }
        return false;
    }
}
