/**
 * Created by Aleksandr on 5/12/2016.
 */
import java.io.*;
import java.util.*;

public class Connecter {

    public void serializationMenu(Menu menu) throws IOException {
        File f=new File("D:\\Универ\\6 семестр\\Java\\Solution5\\menu.data");
        if(!f.exists()){
            f.createNewFile();
        }
        FileOutputStream fileOut = new FileOutputStream("D:\\Универ\\6 семестр\\Java\\Solution5\\menu.data");
        ObjectOutputStream out = new ObjectOutputStream(fileOut);
        out.writeObject(menu);
        out.close();
        fileOut.close();
    }

    public Menu deserializationMenu() throws IOException, ClassNotFoundException {
        File f=new File("D:\\Универ\\6 семестр\\Java\\Solution5\\menu.data");
        FileInputStream fileIn = new FileInputStream(f);
        ObjectInputStream in = new ObjectInputStream(fileIn);
        Menu menu = (Menu) in.readObject();
        in.close();
        fileIn.close();
        return menu;
    }

    public void serializationEmployees(ArrayList<Employee> employees) throws IOException {
        File f=new File("D:\\Универ\\6 семестр\\Java\\Solution5\\orders.data");
        /*if(!f.exists()){
            f.createNewFile();
        }*/
        FileOutputStream fileOut = new FileOutputStream(f);
        ObjectOutputStream out = new ObjectOutputStream(fileOut);
        out.writeObject(employees);
        out.close();
        fileOut.close();

    }

    public ArrayList<Employee> deserializationEmployees() throws IOException, ClassNotFoundException {
        FileInputStream fileIn = new FileInputStream("D:\\Универ\\6 семестр\\Java\\Solution5\\orders.data");
        ObjectInputStream in = new ObjectInputStream(fileIn);
        ArrayList<Employee> employees = (ArrayList<Employee>) in.readObject();
        in.close();
        fileIn.close();
        return employees;
    }
}
