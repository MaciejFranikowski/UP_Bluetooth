   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L5clr-namespace:System.Diagnostics;assembly=WindowsBaseSystem.Diagnostics  5   	   F BBluetoothUP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BluetoothUPBluetoothUP 5   	      BluetoothUP.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      5   	   @d2http://schemas.microsoft.com/expression/blend/2008      5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006      5   	   Fdiag5clr-namespace:System.Diagnostics;assembly=WindowsBase      5   	   +localclr-namespace:BluetoothUP      5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � .+�5   
   �� $	��112��6   $��24��5      $��	10,0,0,31q�5      $
��Left=�5      $��Bottom=�5      $��Select adapter��5      �� 5   
   -   5         ��Name$ comboBoxAdapter��5      $	��136��5      $��21��5      $��	10,0,0,10q�5      $
��Left=�5      $��Bottom=�5       �� DisplayMemberPath$
 Name��5      ��5      �� *
BtAdapters+1   +System.Diagnostics.PresentationTraceSources   
TraceLevel$
 High=� �� SelectedItem 5      �� *CurrentAdapter+�� 5   
   -   5        $	��124��5      $��21��5      $��
151,0,0,10q�5      $
��Left=�5      $��Bottom=�5      $��Update adapters��5       �� 5!   
   -   5        $	��124��5!      $��21��5"      $��
280,0,0,10q�5#      $
��Left=�5$      $��Bottom=�5%      $��Search for BT Devices��5'      �� 5(   
   -   5        $ comboBoxBTDevices��5(      $	��136��5)      $��21��5*      $��
409,0,0,10q�5+      $
��Left=�5,      $��Bottom=�5-      ��5.      �� *bluetoothDevices+ 5/      �� *chosenDevice+50      51      