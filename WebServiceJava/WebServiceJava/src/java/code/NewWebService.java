/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package code;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author Hoc vien
 */
@WebService(serviceName = "NewWebService")
public class NewWebService {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "SNT")
    public String SNT(int a,int b,int c,int d,int e) {
        //TODO write your implementation code here:
        int[] nums ={a,b,c,d,e};
        String numsSNT ="";
       
        for(int i=0;i<nums.length;i++){
            if(CheckSNT(nums[i])==true)
            {
                numsSNT += nums[i]+" ";
            }
        
        }
        return numsSNT.trim();
    }
   private boolean CheckSNT(int k){
        if(k<=1) return false;
        if(k == 2) return true;
        for(int i=2;i<=Math.sqrt(k);i++){
            if(k%i==0)
                return false;
        }
        return true;
    }
    /**
     * Web service operation
     */
    @WebMethod(operationName = "NumsChan")
    public String NumsChan(int a,int b,int c,int d,int e) {
        //TODO write your implementation code here:
           int[] nums = {a,b,c,d,e};
       String numschan ="";
       for(int i=0;i<nums.length;i++){
           if(nums[i]%2 == 0)
               numschan+=nums[i]+" ";
       }
       return numschan.trim();
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "NumsLe")
    public String NumsLe(int a,int b,int c,int d,int e) {
        //TODO write your implementation code here:
            int[] nums = {a,b,c,d,e};
       String numsle ="";
       for(int i=0;i<nums.length;i++){
           if(nums[i]%2 != 0)
               numsle+=nums[i]+" ";
       }
       return numsle.trim();
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "Average")
    public Double Average(int a,int b,int c,int d,int e) {
        //TODO write your implementation code here:
        return (a+b+c+d+e)/5.0;
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "TimMax")
    public Integer TimMax(int a,int b,int c,int d,int e) {
        //TODO write your implementation code here:
       int max;
        int[] nums ={a,b,c,d,e};
        max = nums[0];
        for(int i=0;i<nums.length;i++){
            if(max <nums[i])
            {
                max = nums[i];
            }
        }
        return max;
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "TimMin")
    public Integer TimMin(int a,int b,int c,int d ,int e) {
        //TODO write your implementation code here:
        int min;
        int[] nums ={a,b,c,d,e};
        min = nums[0];
        for(int i=0;i<nums.length;i++){
            if(min > nums[i])
            {
                min = nums[i];
            }
        }
        return min;
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "Sum")
    public Integer Sum(int a,int b,int c,int d,int e) {
        //TODO write your implementation code here:
        return a+b+c+d+e;
    }
    
}
