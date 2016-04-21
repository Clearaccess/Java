package com.ssu.aleksandr_vanyukov.java.task1;

/**
 * Created by Aleksandr on 03.03.2016.
 */
import java.io.*;
import java.util.*;



public class Solution {
    public static void main (String[] argv) throws IOException
    {
        Solution app=new Solution();
        app.startApplication();
    }
    public void startApplication() throws IOException
    {
        BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
        StringTokenizer st = new StringTokenizer(in.readLine());
        System.out.println("Enter count elements: ");
        int n=Integer.parseInt(st.nextToken());
        System.out.println("Enter "+n+" elements: ");
        int[] massive=new int[n];
        for(int i=0;i<n;i++)
        {
            massive[i]=Integer.parseInt(st.nextToken());
        }
        Sort(massive,n);
        for(int i=0;i<n;i++)
        {
            System.out.println(massive[i]);
        }
    }
    public void Sort(int[] massive,int n)
    {
        for(int i=1;i<n;i++)
        {
            int j=i;
            while(j-1>=0 && massive[j]<massive[j-1])
            {
                int temp=massive[j-1];
                massive[j-1]=massive[j];
                massive[j]=temp;
                j--;
            }
        }
    }
}
