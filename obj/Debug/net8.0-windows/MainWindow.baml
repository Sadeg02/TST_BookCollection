   M S B A M L   `   `   `  ����M  ITSD_BookCollection, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TSD_BookCollectionTSD_BookCollection  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   #    TSD_BookCollection.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   2local clr-namespace:TSD_BookCollection     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$  Book Collection��5   	   $	��450��6!   $	��800��6.    � 	Resources 5         BookTemplate � ColumnDefinitions �� Padding  
bookFormat S� 
MethodName S� 
ObjectTypeU QSystem.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a  System.Enum S� MethodParameters M� TypeName  	BoolToVis��%  &	        &	 j    &	 �    �� 5	   
   .R�5
      �� 
�������$��0,0,0,1q�6(   ._�5      �  5      �� 5      $��1* �6+   �� 5      $
��Auto �6+   �� 5      $��4* �6+   �� 5      $
��Auto �6+   �� 5      $��1* �6+   .+�5      �� $��0��6    $ 5q�6D   ��60   �� *Id+6D   �� 5      $��1��6   
�������$��1,0,0,0q�6@   �� 5      $��2��6    $ 5q�6G   $
��Wrap=�6S   ��60   �� *Title+6S   �� 5      $��3��6   
�������$��1,0,0,0q�6@   �� 5      $��4��6    $ 5q�6H   $��Center=�6T   ��60   �� *IsRead+6T   5      5      5      S� 5   
   $ 	GetValues��60   "  6G    5   
   M� 5      $ local:BookFormat��6   5       �� 5!      6#   5"      .��5%      �  � RowDefinitions 5&   
   �� 5'      $
��Auto �6   �� 5(      $��* �6   �� 5)      $
��Auto �6   .+�5,      � $��0��6   $��10q�6    5-      �� 5.   
   $
��Auto �6   �� 5/   
   $��* �6   .+�53      �� $��0��6   $��/images/logo.png��6   $	��100��54      $	��100��6   $��Center=�55      $��0,0,10,0q�56      �� 59      $��1��6   $��Book Collection��5:      $��Center=�5;      $��Center=�5<      $
��Bold"�5=      $��20(�5>      5?      � 5C   
   $��1��6    5D      �� 5E      $��* �6#   �� 5F      $��* �6#   .+�5I      �� $��10q�6   $��0��6%   .+�5J      �� $��	My Books:��6   $��16(�6-   $
��Bold"�6;   $��0,0,0,10q�6M   �� 5K      -   5        $��Add Book��5K      $��2��6,   $��10q�69   $
��Left=�5M   	   $	��5,2q�5N   	   �� 5Q      
�������$��1q�6,   $��0,0,0,5q�6@   ._�5R      �  5S      �� 5T      $��1* �6/   �� 5U      $
��Auto �6/   �� 5V      $��4* �6/   �� 5W      $
��Auto �6/   �� 5X      $��1* �6/   .+�5[      �� $��0��6$   $��ID��64   $
��Bold"�6>   $ 5q�6P   �� 5\      $��1��6!   
�������$��1,0,0,0q�6D   �� 5]      $��2��6$   $��Title��64   $
��Bold"�6A   $ 5q�6S   �� 5^      $��3��6!   
�������$��1,0,0,0q�6D   �� 5_      $��4��6$   $��IsRead��64   $
��Bold"�6B   $ 5q�6T   $��Center=�6`   5`      5a      �� 5d      #��[  5f   
   
�������$��1q�5h   
   $��Stretch=�5i   
   $
��Auto=�5j   
   $	��300��5k   
   ��5d      �� *Books+	 �� SelectedItem	 5e   
   �� *SelectedBook+
 �� Mode$
 TwoWay=�5k   
   5o      �� 5q      $��1��6	   
�������$��1q�6,    �� Padding$ 10q�6@   $��10q�6M   ._�5r      �� .+�5s   
   �� $��Book Details��6   $
��Bold"�6(   $��16(�6:   $��0,0,0,10q�6H   �� 5u   
   $	��ID:��6   $
��Bold"�6   �� 5v   
   $��0,0,0,10q�6j   ��6   �� *SelectedBook.Id+ �� RelativeSource ��  �� AncestorType
 Window6j   �� 5x   
   $��Title:��6   $
��Bold"�6"   �� 5y   
    �� TextWrapping$
 Wrap=�5z      $��0,0,0,10q�6&   ��5y      �� *SelectedBook.Title+ �� 
 Window$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5z   &   �� 5|   
   $��Author:��6   $
��Bold"�6#   �� 5}   
   $��0,0,0,10q�5~      ��5}      �� *SelectedBook.Author+ �� 
 Window$
 TwoWay=�$ PropertyChanged=�5~      �� 5�   
   $��Year:��6   $
��Bold"�6!   �� 5�   
   $��0,0,0,10q�5�      ��5�      �� *SelectedBook.Year+ �� 
 Window$
 TwoWay=�$ PropertyChanged=�5�      �� 5�   
   $��Format:��6   $
��Bold"�6#   �� 5�   
   $��0,0,0,10q�5�      ��5�      ��  �� Source# [ 	 5�      �� *SelectedBook.Format+$
 TwoWay=�$ PropertyChanged=�5�      �� 5�   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5�      �� $
��Read��5�       d� 	IsChecked 5�      �� *SelectedBook.IsRead+ �� 
 Window$
 TwoWay=�5�      5�      �� 5�      -   5        $��Delete Book��5�      
���Gc��
�������6V   5�      5�      5�      �� 5�   
   $��2��6   $��Footer��6!   $��Center=�6/   $��Center=�6L   $��Italic$�6g   $��10q�6z   5�      5�      