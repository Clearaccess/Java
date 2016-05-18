import java.util.*;
import java.io.*;
/**
 * Created by Aleksandr on 10.03.2016.
 */
public class Solution {

    public static void main(String[] argv) throws IOException, DAOFormatException, MenuNullException, ClassNotFoundException, DAORemoveException {
        Solution app=new Solution();
        app.startApplication();
    }
    public void startApplication() throws IOException, DAOFormatException, MenuNullException, ClassNotFoundException, DAORemoveException {
        ReportsService rep = new ReportsService();
        BLL query=new BLL();

        query.addDish("Dish1",new Dish(100.0,100.0));
        query.addDish("Dish2",new Dish(100.0,100.0));
        HashMap<String,Integer>order=new HashMap<String,Integer>();
        order.put("Dish1",2);
        order.put("Dish2",8);
        query.addOrder("Name1",new Order(order));
        try {
            query.removeDish("Dish1");
        }
        catch (DAORemoveException e){
            System.err.println("DAORemoveException: remove dish use in one and more orders");
        }

        try {
            rep.printReport1();
        }
        catch(MenuNullException e){
        }
        rep.printReport2();
    }
}
