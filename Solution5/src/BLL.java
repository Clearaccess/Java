import java.io.IOException;

/**
 * Created by Aleksandr on 5/18/2016.
 */
public class BLL {
    DAO data;
    public BLL() throws MenuNullException, DAOFormatException, IOException {
        data=new DAO();
    }

    public void addOrder(String nameEmployee, Order infOrder) throws IOException, ClassNotFoundException {
        data.addOrder(nameEmployee,infOrder);
    }

    public void removeOrder(String nameEmployee) throws IOException, ClassNotFoundException {
        data.removeOrder(nameEmployee);
    }

    public void addDish(String nameDish, Dish infDish) throws IOException, ClassNotFoundException, MenuNullException {
        data.addDish(nameDish,infDish);
    }

    public void removeDish(String nameDish) throws IOException, ClassNotFoundException, MenuNullException, DAORemoveException {
        data.removeDish(nameDish);
    }
}
