   M S B A M L   `   `   `  ����D  @QLThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:QLThuVien	QLThuVien  5          QLThuVien.uc_dg_dangMuon   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:QLThuVien     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	         MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      � 
������� � 	Resources 5   
    �� 
TargetType �� Property �� Value��%W   '�       �� 5      " �6   .�5      ��  � ��$ 5 0 0 5q�6+   5      5       � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $��50 �6   6+   �� 5      $��50 �6   6+   �� 5       6   �� 5"      $��50 �6   6+   .+�5%   
   � $��0��6   .+�5&      �� $��ĐANG MƯỢN��6   $��20(�6)   $��Normal$�5'      $��Center=�6+   
����d�5*      5+      � 5-   
   $��1��6   .+�5/      �� $��Mã phiếu :��6   $��15(�6*   $��Normal$�50      $��Center=�51       $��	0,0,704,0q�6B   �� 54      $��15(�67   $��Normal$�55      $��Center=�56       $��100,0,440,0q�6B   ��54      �� *DMMaPhieuMuon+56   B   5:      � 5<   
   $��2��6   .+�5>      �� $��Ngày mượn :��6   $��15(�6+   $��Normal$�5?      $��Center=�5@       $��	0,0,692,0q�6B   �� 5C      $��15(�64   $��Normal$�5D      $��Center=�5E       $��
98,0,475,0q�5F       J� RenderTransformOrigin$ 0.5,0.5&�6(   ��5C      �� *
DMNgayMuon+z�5H      V� 5I      .~�5J      ��  �� ScaleX$ -1Q�6)   �� 5K      �� 5L      T� 5M      5N      5P      �� 5S      $��Ngày trả dự kiến :��6   $��15(�62   $��Normal$�5T      $��Center=�5U       $��379,0,282,0q�6B   �� 5X      $��15(�69   $��Normal$�5Y      $��Center=�5Z       $��500,0,106,0q�5\      ��5X      �� *DMNgayTraDuKien+5\      5`      � 5c   
   $��4��6   .+�5d      ��  " MaterialDesignRaisedDarkButton#��[ 5e      	 � ToolTip$8	 2Resource name: MaterialDesignRaisedLightDarkButton��5f      $��
640,6,10,7q�5g   +   ��6   �� *	DMTraSach+.��5h      Trả Sách5i      5j      � 5l   
   $��3��6   .+�5m      �� ��6   �� *DANGMUONLIST+
 �� SelectedItem
 5n       �� *SelectedDangMuon+ �� View 5o      �� 5p      .P�5r      �� $��	Mã Sách��6)    �� DisplayMemberBinding 6;   �� *MASACH+6f   5t      5v      5x      5y      5|      