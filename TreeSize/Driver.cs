using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSize
{

    

    //stuff from java
//    public static void main(String[] args) throws Exception
//    {
//        //createGUI();
//        File f = new File(args[0]);



//    File[] files = f.listFiles();
//		for(int i = 0; i<files.length; i++) {
//			//System.out.println(files[i].getName() + "...." + checkWritable(files[i]));
//			//System.out.println(files[i].getName() + "......" + getSize(files[i]));
//			if(checkReadable(files[i])) {print(files[i]);
//}
//			else {System.out.println(files[i].getName() + "...." + "protected");}
//		}
//	}
	
	
	
//	public static long getSize(File f)
//{
//    long size = 0;
//    File[] contents = f.listFiles();
//    for (int i = 0; i < contents.length; i++)
//    {
//        if (checkReadable(contents[i]))
//        {
//            if (contents[i].isDirectory()) size += getSize(contents[i]);
//            else size += contents[i].length();
//        }
//    }
//    return size;
//}

//public static void print(File f) throws Exception
//{
//		//Document doc = jtp.getDocument();
//		long size = 0;
//		if(checkReadable(f)) {
//        if (f.isDirectory()) { size = getSize(f); }
//        else { size = f.length(); }
//    }
//    //doc.insertString(doc.getLength(), f.getName() + "......" + size + "\n", null);
//    System.out.println(f.getName() + "......" + size);
//}

//public static boolean checkReadable(File f)
//{
//    return Files.isReadable(Paths.get(f.getAbsolutePath()));
//}

public sealed class Driver
    {
        //add a set to store already calculated directories so you don't have to calculate again
        //set of pairs string,long
        static Hashtable directories = new Hashtable();

        //singleton instance definition
        private static readonly Driver instance = new Driver();
        private Driver() { }
        public static Driver Instance
        {
            get
            {
                return instance;
            }
        }
        //end singleton instance definition

        //function takes in input directory/path and returns total size
        //break into 3 overloaded functions
        public static long getSize(FileInfo file)
        {

        }

        public static long getSize(DirectoryInfo directory)
        {

        }
        public static long getSize(string path)
        {
            

            //if file, return length
            if (!isDirectory(path))
            {
                FileInfo current = new FileInfo(path);
                return current.Length;
            }
            
            long size = 0;

            //if directory
            //  check table for path
            //      if table contains path return size from table
            //  get list of subdirectories
            //  recurse for each subdir
            //  get list of files
            //  add lengths to size
            //  add pathname and size to table

            return size;    
        }

        //function takes in input path and returns array of child directories/files and sizes

        //check if directory
        public static Boolean isDirectory(string path)
        {
            FileAttributes attr = File.GetAttributes(path);
            return attr.HasFlag(FileAttributes.Directory);
        }
    }
}
