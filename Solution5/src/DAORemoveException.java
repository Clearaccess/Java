/**
 * Created by Aleksandr on 5/18/2016.
 */
public class DAORemoveException extends Exception {
    public DAORemoveException() {

    }

    public DAORemoveException(String message, Throwable cause) {
        super(message,cause);
    }

    public DAORemoveException(String message){
        super(message);
    }

    public DAORemoveException(Throwable cause){
        super(cause);
    }
}
