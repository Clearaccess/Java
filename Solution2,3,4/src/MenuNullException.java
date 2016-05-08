/**
 * Created by Aleksandr on 5/5/2016.
 */
public class MenuNullException extends Exception {

    public MenuNullException(){

    }

    public MenuNullException(String message, Throwable cause){
        super(message,cause);
    }

    public MenuNullException(String message){
        super(message);
    }

    public MenuNullException(Throwable cause){
        super(cause);
    }
}
