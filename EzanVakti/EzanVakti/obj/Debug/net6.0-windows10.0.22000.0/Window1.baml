   M S B A M L   `   `   `  ????D  @EzanVakti, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:EzanVakti	EzanVakti  5   	       EzanVakti.Window1   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:EzanVakti     5   	     ? Title$  Window1??5   	   $	??550??6   $	??400??6&   .??5
      ? $	??430??6   $	??530??6    J? OpacityMask
 ?   ?.+?5   
   (? -   5         (?Name$ viewboxResim??5      $	??530??6)   $	??400??66    (? Stretch$ UniformToFill=?6B   $??	-30,0,0,0q?6Z   .??5      ?? -   5         ??Name$ arkaplanresmi??5      $??/aksamImg.jpg??6+   5      ? 5   
   $	??500??6   $	??430??6   .+?5      A? $
??1100??6   $
??1000??6#   $??-450,60,0,0q?61   
???   ?$??0??6U   ??5      ?? 5       ?? Color$ Black??6&    ?? Opacity$	 0.4Q?64   5      5      ? 5   
   -   5         ?Name$ 	gridYatsi??5      $??230,80,8,120q?6"   $??50??68   $??70??6C   .+?5      ?? -   5         ??Name$ 	rectYatsi??5      $??50??6+   $??70??66   $??1??6B   
???????	 ?? RadiusX$	 10??6h   
 ?? RadiusY$
 10??6u   ??5      ?? 5      $ Black??6&   $	 0.5Q?64   5       ?? 5!      -   5         ??Name$ 	KareYatsi??5!      $??Yatsı1??6'   $??23??68   $??43??6D   $??10(?6O   
???????$??	7,-3,0,41q?6p   ?? 5#      -   5        $ 
yatsiresim??5#      $??50??6(   $??/yatsiWhite.png??64   $??50??6M    J? RenderTransformOrigin$ -0.507,0.523&?6X    J? Opacity$ 1Q?6}   
 ?????$??-4,0,0,0q?6?   ?? 5&      -   5        $ 
yatsiVakti??5&      $?? ??6(   $??50??63   $??27??6>   
???????$ 
0.49,1.346&?6]   $??	7,5,0,-38q?6?   5(      ? 5)   
   -   5        $ 	gridImsak??5)      $??50??6"   $??70??6-   $??-320,80,8,120q?69   .+?5+      ?? -	   5        $ 	rectImsak??5+      $??50??6+   $??70??66   $??1??6B   
???????$	 10??6h   $
 10??6u   ??5-      ?? 5.      $ Black??6&   $	 0.5Q?64   50      ?? 51      -
   5        $ 	KareImsak??51      $??imsak??6'   
???????$??5,0,0,41q?6J   $??10(?6\   $??23??6j   $??43??6v   ?? 52      -   5        $ 
imsakresim??52      $??/imsakWhite.png??6(   $??50??6A   $??50??6L   $??UniformToFill=?6X   $??	-20,0,0,0q?6p   ?? 53      -   5        $ 
imsakvakti??53      $?? ??6(   
???????$??43??6F   $??23??6Q   $??-8,0,-15,-37q?6]   54      ? 55   
   -   5        $ 	gridGunes??55      $??50??6"   $??70??6-   $??-210,80,8,120q?69   .+?57      ?? -   5        $ 	rectGunes??57      $??50??6+   $??70??66   $??1??6B   
???????$	 10??6h   $
 10??6u   ??59      ?? 5:      $ Black??6&   $	 0.5Q?64   5<      ?? 5=      -   5        $ 	KareGunes??5=      $??Güneş??6'   $??5,0,0,40q?67   $??10(?6I   $??23??6W   
???????$??43??6v   ?? 5>      -   5        $ 
gunesresim??5>      $??/gunesBeyaz.png??6(   $??30??6A   $??30??6L   $??UniformToFill=?6X   $ 1Q?6p   $??0,0,15,0q?6|   ?? 5?      -   5        $ 
gunesvakti??5?      $?? ??6(   $??43??63   $??23??6>   
???????$??0,39,0,0q?6]   5@      ? 5A   
   -   5        $ gridOGle??5A      $??50??6!   $??70??6,   $??-100,80,8,120q?68   .+?5C      ?? -   5        $ rectOgle??5C      $??50??6*   $??70??65   $??1??6A   
???????$	 10??6g   $
 10??6t   ??5E      ?? 5F      $ Black??6&   $	 0.5Q?64   5H      ?? 5I      -   5        $ KareOgle??5I      $??Öğle??6&   $??23??65   $??43??6A   $??10(?6L   
???????$??	8,-4,0,37q?6m   ?? 5J      -   5        $ 	ogleresim??5J      $??50??6'   $??/ogleWhite.png??63   $??50??6K   $??UniformToFill=?6V   $ -0.507,0.523&?6n   $??	-16,0,0,0q?6?   ?? 5K      -   5        $ 	ogleVakti??5K      $?? ??6'   $??50??62   $??27??6=   
???????$ 
0.49,1.346&?6\   $??	0,43,-9,0q?6   5L      ? 5M   
   -   5        $ gridIkındı??5M      $??50??6#   $??70??6.   $??10,80,8,120q?6:   .+?5O      ?? -   5        $ rectIkındı??5O      $??50??6,   $??70??67   $??1??6C   
???????$	 10??6i   $
 10??6v   ??5Q      ?? 5R      $ Black??6&   $	 0.5Q?64   5T      ?? 5U      -   5        $ 
KareIkindi??5U      $??ikindi??6(   $??23??69   $??43??6E   $??10(?6P   
???????$??	6,-1,0,40q?6q   ?? 5V      -   5        $ ikindiresim??5V      $??50??6)   $??/ikindiWhite.png??65   $??50??6O   $??UniformToFill=?6Z   $ -0.507,0.523&?6r   $??	-16,0,0,0q?6?   ?? 5W      -   5        $ ikindiVakti??5W      $?? ??6)   $??50??64   $??27??6?   
???????$ 
0.49,1.346&?6^   $??3,44,0,0q?6?   5X      ? 5Y   
   -   5        $ 	gridAksam??5Y      $??50??6"   $??70??6-   $??120,80,8,120q?69   .+?5[      ?? -   5        $ 	rectAksam??5[      $??50??6+   $??70??66   $??1??6B   
???????$	 10??6h   $
 10??6u   ??5]      ?? 5^      -   5        
rectDeneme??$ Black??5^   :   $	 0.5Q?6H   5`      ?? 5a      -   5        $ 	KareAksam??5a      $??Akşam??6'   $??23??67   $??43??6C   $??10(?6N   
???????$??	0,-3,0,39q?6o   ?? 5b      -    5        $ 
aksamresim??5b      $??50??6(   $??/aksamWhite.png??64   $??50??6M   $??UniformToFill=?6X   $ -0.507,0.523&?6p   $??	-16,0,0,0q?6?   ?? 5c      -!   5        $ 
AksamVakti??5c      $?? ??6(   $??50??63   $??27??6>   
???????$ 
0.49,1.346&?6]   $??7,44,0,0q?6?   5d      ?? 5e   
   -"   5        $ gunesImg??5e      $??UniformToFill=?6#   ?? 5f   
   -#   5        $ 
HijriLabel??5f      $?? ??6$   $
??Left=?6/   $??
35,140,0,0q?6J   $	??Top=?6^   
???????$??15(?6?   ?? 5g   
   -$   5        $ 	GregLabel??5g      $?? ??6#   $
??Left=?6.   $??167,141,0,0q?6I   $	??Top=?6^   
???????$??13(?6?   ?? 5h   
   -%   5        $ YerelSaatLabel??5h      $?? ??6(   $
??Left=?63   $??264,141,0,0q?6N   $	??Top=?6c   
???????$??14(?6?   ?? 5j   
   	 ?? Y1$ 0??6   	 ?? Y2$ 60??6   $??130,140,0,0q?6   
???????$??1??6B   ?? 5k   
   $ 0??6   $ 60??6   $??250,140,0,0q?6   
???????$??1??6B   ?? 5m   
   -&   5        $ vakit??5m      $?? ??6   $
??Left=?6*   $??	27,80,0,0q?6E   $	??Top=?6X   
???????$??15(?6?   ?? 5n   
   -'   5        $ 
kalanZaman??5n      $?? ??6$   $
??Left=?6/   $??
34,101,0,0q?6J   $	??Top=?6^   
???????$??22(?6?   ?? 5o   
   $??İmsak??6   $
??Left=?6    $??
74,295,0,0q?6;   $	??Top=?6O   
???????6g   ?? 5p   
   $??Güneş??6   $
??Left=?6    $??124,295,0,0q?6;   $	??Top=?6P   
???????6h   ?? 5q   
   $??Öğle??6   $
??Left=?6   $??174,295,0,0q?6:   $	??Top=?6O   
???????6g   ?? 5r   
   $??Yatsı??6   $
??Left=?6    $??324,295,0,0q?6;   $	??Top=?6P   
???????6h   ?? 5s   
   $??Akşam??6   $
??Left=?6    $??274,295,0,0q?6;   $	??Top=?6P   
???????6h   ?? 5t   
   $??İkindi??6   $
??Left=?6!   $??224,295,0,0q?6<   $	??Top=?6Q   
???????6i   ?? 5u   
   $????______________________________________________________________________________________________________________________________________??6   $
??Left=?6?   $??
18,324,0,0q?6?   $	??Top=?6?   
???????6?   ?? 5v   
   -(   5        $
 gun1??5v      $?? ??6   
???????$
??Left=?6<   $??
20,320,0,0q?6W   $	??Top=?6k   ?? 5w   
   -)   5        $
 gun2??5w      $?? ??6   $
??Left=?6)   $??
20,345,0,0q?6D   $	??Top=?6X   
???????6p   ?? 5x   
   -*   5        $
 gun3??5x      $?? ??6   $
??Left=?6)   $??
20,370,0,0q?6D   $	??Top=?6X   
???????6p   ?? 5y   
   -+   5        $
 gun4??5y      $?? ??6   $
??Left=?6)   $??
20,395,0,0q?6D   $	??Top=?6X   
???????6p   ?? 5z   
   -,   5        $
 gun5??5z      $?? ??6   $
??Left=?6)   $??
20,420,0,0q?6D   $	??Top=?6X   
???????6p   ?? 5{   
   --   5        $
 gun6??5{      $?? ??6   $
??Left=?6)   $??
20,445,0,0q?6D   $	??Top=?6X   
???????6p   ?? 5|   
   -.   5        $
 gun7??5|      $?? ??6   $
??Left=?6)   $??
20,470,0,0q?6D   $	??Top=?6X   
???????6p   ?? 5}   
   -/   5         ??Name$ imsak1??5}      
???????$
??Left=?67   $??
80,325,0,0q?6R   $
??Wrap=?6f   $?? ??6z   $	??Top=?6?   ?? 5~   
   -0   5        $ imsak2??5~      $
??Left=?6$   $??
80,350,0,0q?6?   $
??Wrap=?6S   $?? ??6g   $	??Top=?6o   
???????6?   ?? 5   
   -1   5        $ imsak3??5      $
??Left=?6$   $??
80,375,0,0q?6?   $
??Wrap=?6S   $?? ??6g   $	??Top=?6o   
???????6?   ?? 5?   
   -2   5        $ imsak4??5?      $
??Left=?6$   $??
80,400,0,0q?6?   $
??Wrap=?6S   $?? ??6g   $	??Top=?6o   
???????6?   ?? 5?   
   -3   5        $ imsak5??5?      $
??Left=?6$   $??
80,425,0,0q?6?   $
??Wrap=?6S   $?? ??6g   $	??Top=?6o   
???????6?   ?? 5?   
   -4   5        $ imsak6??5?      $
??Left=?6$   $??
80,450,0,0q?6?   $
??Wrap=?6S   $?? ??6g   $	??Top=?6o   
???????6?   ?? 5?   
   -5   5        $ imsak7??5?      $
??Left=?6$   $??
80,475,0,0q?6?   $
??Wrap=?6S   $?? ??6g   $	??Top=?6o   
???????6?   ?? 5?   
   -6   5        $ gunes1??5?      $
??Left=?6$   $??130,325,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -7   5        $ gunes2??5?      $
??Left=?6$   $??130,350,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -8   5        $ gunes3??5?      $
??Left=?6$   $??130,375,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -9   5        $ gunes4??5?      $
??Left=?6$   $??130,400,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -:   5        $ gunes5??5?      $
??Left=?6$   $??130,425,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -;   5        $ gunes6??5?      $
??Left=?6$   $??130,450,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -<   5        $ gunes7??5?      $
??Left=?6$   $??130,475,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -=   5        $ ogle1??5?      $
??Left=?6#   $??180,325,0,0q?6>   $
??Wrap=?6S   $?? ??6g   $	??Top=?6o   
???????6?   ?? 5?   
   ->   5        $ ogle2??5?      $
??Left=?6#   $??180,350,0,0q?6>   $
??Wrap=?6S   $?? ??6g   $	??Top=?6o   
???????6?   ?? 5?   
   -?   5        $ ogle3??5?      $
??Left=?6#   $??180,375,0,0q?6>   $
??Wrap=?6S   $?? ??6g   $	??Top=?6o   
???????6?   ?? 5?   
   -@   5        $ ogle4??5?      $
??Left=?6#   $??180,400,0,0q?6>   $
??Wrap=?6S   $?? ??6g   $	??Top=?6o   
???????6?   ?? 5?   
   -A   5        $ ogle5??5?      $
??Left=?6#   $??180,425,0,0q?6>   $
??Wrap=?6S   $?? ??6g   $	??Top=?6o   
???????6?   ?? 5?   
   -B   5        $ ogle6??5?      $
??Left=?6#   $??180,450,0,0q?6>   $
??Wrap=?6S   $?? ??6g   $	??Top=?6o   
???????6?   ?? 5?   
   -C   5        $ ogle7??5?      $
??Left=?6#   $??180,475,0,0q?6>   $
??Wrap=?6S   $?? ??6g   $	??Top=?6o   
???????6?   ?? 5?   
   -D   5        $ ikindi1??5?      $
??Left=?6%   $??230,325,0,0q?6@   $
??Wrap=?6U   $?? ??6i   $	??Top=?6q   
???????6?   ?? 5?   
   -E   5        $ ikindi2??5?      $
??Left=?6%   $??230,350,0,0q?6@   $
??Wrap=?6U   $?? ??6i   $	??Top=?6q   
???????6?   ?? 5?   
   -F   5        $ ikindi3??5?      $
??Left=?6%   $??230,375,0,0q?6@   $
??Wrap=?6U   $?? ??6i   $	??Top=?6q   
???????6?   ?? 5?   
   -G   5        $ ikindi4??5?      $
??Left=?6%   $??230,400,0,0q?6@   $
??Wrap=?6U   $?? ??6i   $	??Top=?6q   
???????6?   ?? 5?   
   -H   5        $ ikindi5??5?      $
??Left=?6%   $??230,425,0,0q?6@   $
??Wrap=?6U   $?? ??6i   $	??Top=?6q   
???????6?   ?? 5?   
   -I   5        $ ikindi6??5?      $
??Left=?6%   $??230,450,0,0q?6@   $
??Wrap=?6U   $?? ??6i   $	??Top=?6q   
???????6?   ?? 5?   
   -J   5        $ ikindi7??5?      $
??Left=?6%   $??230,475,0,0q?6@   $
??Wrap=?6U   $?? ??6i   $	??Top=?6q   
???????6?   ?? 5?   
   -K   5        $ aksam1??5?      $
??Left=?6$   $??280,325,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -L   5        $ aksam2??5?      $
??Left=?6$   $??280,350,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -M   5        $ aksam3??5?      $
??Left=?6$   $??280,375,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -N   5        $ aksam4??5?      $
??Left=?6$   $??280,400,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -O   5        $ aksam5??5?      $
??Left=?6$   $??280,425,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -P   5        $ aksam6??5?      $
??Left=?6$   $??280,450,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -Q   5        $ aksam7??5?      $
??Left=?6$   $??280,475,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -R   5        $ yatsi1??5?      $
??Left=?6$   $??330,325,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -S   5        $ yatsi2??5?      $
??Left=?6$   $??330,350,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -T   5        $ yatsi3??5?      $
??Left=?6$   $??330,375,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -U   5        $ yatsi4??5?      $
??Left=?6$   $??330,400,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -V   5        $ yatsi5??5?      $
??Left=?6$   $??330,425,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -W   5        $ yatsi6??5?      $
??Left=?6$   $??330,450,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ?? 5?   
   -X   5        $ yatsi7??5?      $
??Left=?6$   $??330,475,0,0q?6?   $
??Wrap=?6T   $?? ??6h   $	??Top=?6p   
???????6?   ? 5?   
   ? 5?   
   5?      ?? 5?   
   -Y   5        $ 
HavaDurumu??5?      $
??Left=?6(   $??
28,170,0,0q?6C   $
??Wrap=?6W   $?? ??6k   $	??Top=?6s   $	??100??6?   $??30??6?   
???????$??11(?6?   ?? 5?   
   -Z   5         ??Name$ 
Menubutton??5?      $??325,0,50,447q?6%   $??50??6w   $??50??6?    ? ToolTip$
 Menu??6?   ??5?      ?? 5?       ?? 
TargetType" ??6"   .R?5?      ?? .??5?      ??  ??Name$ myborder??6!    ?? CornerRadius$ 95??64   ._?5?      ? .+?5?   "   A?  A?Name$ 
dugmeSekil??6*   $??50??6>   $??50??6I   $??0,0,0,0q?6U   
???????$??0??6x   ??5?   &   ?? 5?   *   dugmearkaplan??$ Black??6Q   $	 0.6Q?6_   5?   #   ?? 5?   "   $??/menuIcon.png??6(   $??27??6?   $??27??6J   $??UniformToFill=?6V   $??0,0,0,0q?6n   5?      5?      5?       ?? Triggers 5?      P? 5?       P? Property ?@J?IsMouseOver P? Value$
 true??69   . ?5?      ??  ?? 
TargetName$ myborder??6;    ?? Property ? ?? ?? Value
 ? ???6Q   ?? 5?      $ myborder??68    ?@J?Opacity$ 1Q?6N   5?      5?      5?      5?      5?      