import java.util.*;

/**
 * Created by Aleksandr on 3/24/2016.
 */
public class Menu {
    HashMap<String, Dish> dishes;

    public Menu() {
        this.dishes = new HashMap<String,Dish>(0);
    }
    public Menu(HashMap<String, Dish> dishes) {
        this.dishes = dishes;
    }

    public Double getCostDish(String name) {
        return dishes.get(name).getPrice();
    }
}
