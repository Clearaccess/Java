import java.util.*;

/**
 * Created by Aleksandr on 4/7/2016.
 */
public class Order {
    HashMap<String, Integer> dishes;

    public Order(HashMap<String, Integer> dishes){

        this.dishes=dishes;
    }

    public HashMap<String, Integer> getDishes() {
        return dishes;
    }
}
