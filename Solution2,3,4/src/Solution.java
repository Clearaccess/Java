import java.util.*;
import java.io.*;
/**
 * Created by Aleksandr on 10.03.2016.
 */
public class Solution {

    public static void main(String[] argv) throws IOException, DAOFormatException, MenuNullException {
        Solution app=new Solution();
        app.startApplication();
    }
    public void startApplication() throws IOException, DAOFormatException, MenuNullException{
        ReportsService rep=new ReportsService();
        try {
            rep.printReport1();
            rep.printReport2();
        }
        catch(MenuNullException e){
            System.err.println("MenuNullException: Data are lack");
        }
    }
}
