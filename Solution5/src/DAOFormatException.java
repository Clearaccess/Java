/**
 * Created by Aleksandr on 5/5/2016.
 */
public class DAOFormatException extends Exception {

    public DAOFormatException() {

    }

    public DAOFormatException(String message, Throwable cause) {
        super(message,cause);
    }

    public DAOFormatException(String message){
        super(message);
    }

    public DAOFormatException(Throwable cause){
        super(cause);
    }
}
