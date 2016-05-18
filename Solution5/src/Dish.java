import java.io.Serializable;

/**
 * Created by Aleksandr on 10.03.2016.
 */
public class Dish implements Serializable {

    private Double weight;
    private Double price;

    public Dish(Double weight, Double price) {
        this.weight = weight;
        this.price = price;
    }

    public Double getPrice() {
        return price;
    }

    public void setPrice(Double price) {
        this.price = price;
    }

    public Double getWeight() {
        return weight;
    }

    public void setWeight(Double weight) {
        this.weight = weight;
    }
}
