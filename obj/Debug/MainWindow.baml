   M S B A M L   `   `   `  ����B  >ApiTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ApiTestApiTest  5   	   !clr-namespace:ApiTestApiTest  5   a      ApiTest.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ApiTest     5   	   b ^DevExpress.Xpf.Core.v15.2, Version=15.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a<dxb2http://schemas.devexpress.com/winfx/2008/xaml/bars  5   	   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  6H   ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  6�   g cDevExpress.Printing.v15.2.Core, Version=15.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49ahCustom[http://schemas.devexpress.com/winfx/2008/xaml/printingcore/xtraprinting/native/presentation  6�   cclr-namespace:ApiTest  6a    �Language$  en-US�5
   q   -   5         �Name$ ApiTest��5   3   � Title$ winequestTest��5
   	   $	��600��6   $
��1200��6,   $��0q�69   $��0q�6D    � WindowStyle$ 
ToolWindow=�6X    � SizeToContent$ WidthAndHeight=�6q    � 	Resources 5       �� 
TargetType �� Property �� Value��%�  '��       '�� �     '�� �    '�� z    �� 5   
   " ��6   .�5      ��  � ��$ 25��6*   �� 5       � ��$ 35��6*   �� 5       � ��$ Center=�69   �� 5       � ��$
 10,5q�6'   �� 5       � ��$	 200��6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 25��6*   �� 5       � ��$ 35��6*   �� 5       � ��$ Center=�69   �� 5       � ��$
 10,5q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 25��6*   �� 5       � ��$ 35��6*   �� 5       � ��$ Center=�69   �� 5       � ��$
 10,5q�6'   �� 5       � ��$ Right=�64   5      �� 5    
   " ��6   .�5!      ��  � ��$ 25��6*   �� 5"       � ��$ 35��6*   �� 5#       � ��$ Center=�69   �� 5$       � ��$
 10,5q�6'   �� 5%       � ��$	 200��6)   5&      5'      .��5)      � -   5        	 �Name$	 
CommonGrid��5)      
 � ShowGridLines
 .  }�. $��10q�6I   $	��500��6U   $	��500��6d    � RowDefinitions 5*   
   �� 5+      $��35 �6   �� 5,      $��35 �6   �� 5-      $��35 �6   �� 5.      $��35 �6   �� 5/      $��30 �6   �� 50      $
��Auto �6    � ColumnDefinitions 52   
   �� 53      $
��Auto �6   �� 54      $��3* �6   �� 55      $
��Auto �6   �� 56      $��3* �6   �� 57      $
��Auto �6   �� 58      $��3* �6   .+�5;   
   �� -   5         ��Name$ MethodNameLabel��5;   -   $��0��6   $��0��6   $��Method:��6F   �� 5<   
   -   5         ��Name$ 
MethodName��5<   0   $��0��6   $��1��6    .@�5=      �� $��GetCategories��6   �� 5>      $��GetProperties��6   �� 5?      $��GetPropertyNumberById��6   �� 5@      $��GetAllProducts��6   �� 5A      $��GetPropertyProducts��6   �� 5B      $��GetProductByNumber��6   �� 5C      $��GetProductById��6   �� 5D      $!��GetProductByNumberAndDetail��6   �� 5E      $��
GetProduct��6   �� 5F      $��CreateProduct��6   �� 5G      $��UpdatePropertyProduct��6   �� 5H      $��UpdateRootProduct��6   �� 5I      $��MergeProductDetails��6   �� 5J      $��MergeProducts��6   �� 5K      $��ResetDataBase��6   �� 5L      $��UpdateCoreList��6   �� 5M      $��GetCoreList��6   5N      �� 5O   
   -   5        $ EndpointLabel��5O   .   $��0��6   $��2��6   $��	Endpoint:��6E   �� 5P   
   -   5         ��Name$ Endpoint��5P   C   $��0��6   $��3��6   $��2��6/   $C��=http://ie1adddb01.cloudapp.net/DevelopmentService/Product.svc��6U   �� 5Q   
   -   5         ��Name$ Reset��5Q   .   $��0��6   $��6��6   $��Reset��6=   �� 5S   
   -   5        $ Param1Label��5S   -   $��1��6   $��0��6   $��label��6B   �� 5T   
   -	   5        $ Param1��5T   /   $��1��6   $��1��6   $�� ��6?   �� 5U   
   -
   5        $ AdacoDbInstanceLabel��5U   .   $��1��6   $��2��6   $��Adaco-DBInstance:��6L   �� 5V   
   -   5        $ AdacoDbInstance��5V   /   $��1��6   $��3��6   $��
Production��6H   �� 5W   
   -   5        $ AdacoTimestampLabel��5W   .   $��1��6   $��4��6   $��Adaco-Timestamp:��6K   �� 5X   
   -   5        $ AdacoTimestamp��5X   /   $��1��6   $��5��6   $�� ��6G   �� 5Z   
   -   5        $ Param2Label��5Z   -   $��2��6   $��0��6   $��label��6B   �� 5[   
   -   5        $ Param2��5[   /   $��2��6   $��1��6   $�� ��6?   �� 5\   
   -   5        $ AdacoUseridLabel��5\   .   $��2��6   $��2��6   $��Adaco-Userid:��6H   �� 5]   
   -   5        $ AdacoUserid��5]   /   $��2��6   $��3��6   $��	winequest��6D   �� 5^   
   -   5        $ AdacoAuthorizationLabel��5^   .   $��2��6   $��4��6   $��Adaco-Authorization:��6O   �� 5_   
   -   5        $ AdacoAuthorization��5_   /   $��2��6   $��5��6   $�� ��6K   �� 5a   
   -   5        $ Param3Label��5a   -   $��3��6   $��0��6   $��label��6B   �� 5b   
   -   5        $ Param3��5b   /   $��3��6   $��1��6   $�� ��6?   �� 5c   
   -   5        $ SendRequest��5c   .   $��3��6   $��3��6   $��Send Request��6C   5g      5i      