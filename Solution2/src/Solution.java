import java.util.*;
import java.io.*;
/**
 * Created by Aleksandr on 10.03.2016.
 */
public class Solution {

    public static void main(String[] argv) throws IOException {
        Solution app=new Solution();
        app.startApplication();
    }
    public void startApplication() throws IOException{
        ReportsService rep=new ReportsService();
        rep.printReport1();
        rep.printReport2();
    }
}
