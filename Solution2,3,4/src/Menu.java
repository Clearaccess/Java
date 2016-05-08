import java.util.*;

/**
 * Created by Aleksandr on 3/24/2016.
 */
public class Menu {
    HashMap<String, Dish> dishes;

    public Menu() {
        this.dishes = new HashMap<String,Dish>();
    }
    public Menu(HashMap<String, Dish> dishes) throws MenuNullException {
        if(dishes==null){
            throw new MenuNullException();
        }
        this.dishes = dishes;
    }

    public Double getCostDish(String name) throws MenuNullException {
        if(dishes==null || !dishes.containsKey(name)){
            throw new MenuNullException();
        }
        return dishes.get(name).getPrice();
    }
}
