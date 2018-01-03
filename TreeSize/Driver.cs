using System;
using System.Collections.Generic;
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

class Driver
    {
    }
}
