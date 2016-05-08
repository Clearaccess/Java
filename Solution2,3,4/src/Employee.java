import java.util.*;

/**
 * Created by Aleksandr on 3/24/2016.
 */
public class Employee {
    String name;
    Order order;

    public Employee(String name,Order order){
        this.name=name;
        this.order=order;
    }

    public Order getOrder(){
        return order;
    }
}
