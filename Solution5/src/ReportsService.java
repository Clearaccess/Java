import java.io.IOException;
import java.util.*;

/**
 * Created by Aleksandr on 3/31/2016.
 */
public class ReportsService {
    DAO data;

    public ReportsService() throws IOException, DAOFormatException, MenuNullException {
        data=new DAO();
    }

    public void printReport1() throws MenuNullException, IOException, ClassNotFoundException {
        HashMap<String, Integer> orders = new HashMap<String, Integer>();
        for (Employee i : data.getEmployees()) {
            HashMap<String, Integer> temp = i.getOrder().getDishes();
            for (String j : temp.keySet()) {
                if (!orders.containsKey(j)) {
                    orders.put(j, temp.get(j));
                } else {
                    orders.replace(j, orders.get(j) + temp.get(j));
                }
            }
        }

        Double summ = 0.0;
        System.out.println("ПЕРВЫЙ ОТЧЕТ");
        for (String i : orders.keySet()) {
            System.out.println(i + " " + orders.get(i) + " " + data.getMenu().getCostDish(i) * orders.get(i));
            summ += data.getMenu().getCostDish(i) * orders.get(i);
        }
        System.out.println("Полная стоимость заказа: " + summ);
    }

    public void printReport2() throws MenuNullException, IOException, ClassNotFoundException {
        System.out.println("ВТОРОЙ ОТЧЕТ");
        HashMap<String, Integer> orders = new HashMap<String, Integer>();
        for (Employee i : data.getEmployees()) {
            Double summ = 0.0;
            HashMap<String, Integer> temp = i.getOrder().getDishes();
            System.out.print(i.name + ":");
            int cElm = 0;
            int nCol = temp.size();
            for (String j : temp.keySet()) {
                try {
                    summ += temp.get(j) * data.getMenu().getCostDish(j);
                    System.out.print(" " + j);
                }
                catch(MenuNullException e){
                    nCol--;
                }
                if (cElm + 1 < nCol) {
                    System.out.print(",");
                }
                cElm++;
            }
            System.out.println(" " + summ);
        }
    }
}
