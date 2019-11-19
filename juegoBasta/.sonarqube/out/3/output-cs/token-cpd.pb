‰
0C:\Users\survi\Desktop\basta\cliente\App.xaml.cs
	namespace		 	
cliente		
 
{

 
public 

partial 
class 
App 
: 
Application *
{ 
} 
} ¥$
;C:\Users\survi\Desktop\basta\cliente\CodigoRegistro.xaml.cs
	namespace 	
cliente
 
{ 
public 

partial 
class 
CodigoRegistro '
:( )
Window* 0
{ 
public 
CodigoRegistro 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
Button_Click !
(! "
object" (
sender) /
,/ 0
RoutedEventArgs1 @
eA B
)B C
{ 	
ServiceBasta 
. $
ServiceBastaCodigoClient 1$
serviceBastaCodigoClient2 J
=K L
nullM Q
;Q R
try   
{!! 
string"" 
	codigotxt""  
=""! "
textBoxCodigo""# 0
.""0 1
Text""1 5
;""5 6
int## 
	codigoInt## 
=## 
int##  #
.### $
Parse##$ )
(##) *
	codigotxt##* 3
)##3 4
;##4 5$
serviceBastaCodigoClient%% (
=%%) *
new%%+ .
ServiceBasta%%/ ;
.%%; <$
ServiceBastaCodigoClient%%< T
(%%T U
)%%U V
;%%V W
bool&& 
resultadoCodigo&& $
;&&$ %
resultadoCodigo(( 
=((  !$
serviceBastaCodigoClient((" :
.((: ;#
VerificarCodigoRegistro((; R
(((R S
	codigoInt((S \
)((\ ]
;((] ^
if** 
(** 
resultadoCodigo** #
==**$ &
true**' +
)**+ ,
{++ 
CuentaDeUsuario,, #
cuentaDeUsuario,,$ 3
=,,4 5
new,,6 9
CuentaDeUsuario,,: I
(,,I J
),,J K
;,,K L
cuentaDeUsuario-- #
.--# $
Show--$ (
(--( )
)--) *
;--* +
this.. 
... 
Close.. 
(.. 
)..  
;..  !
}// 
else00 
{11 
String22 
mensaje22 "
=22# $
$str22% *
;22* +
String33 
titulo33 !
=33" #
$str33$ O
;33O P
MessageBoxButton44 $
boton44% *
=44+ ,
MessageBoxButton44- =
.44= >
OK44> @
;44@ A

MessageBox55 
.55 
Show55 #
(55# $
mensaje55$ +
,55+ ,
titulo55- 3
,553 4
boton555 :
)55: ;
;55; <
}66 
}77 
catch88 
(88 
TimeoutException88 "
	excepcion88# ,
)88, -
{99 $
serviceBastaCodigoClient:: (
.::( )
Abort::) .
(::. /
)::/ 0
;::0 1
String;; 
mensaje;; 
=;;  
$str;;! 4
+;;5 6
	excepcion;;7 @
.;;@ A
Message;;A H
;;;H I
String<< 
titulo<< 
=<< 
$str<<  5
;<<5 6
MessageBoxButton==  
boton==! &
===' (
MessageBoxButton==) 9
.==9 :
OK==: <
;==< =

MessageBox>> 
.>> 
Show>> 
(>>  
mensaje>>  '
,>>' (
titulo>>) /
,>>/ 0
boton>>1 6
)>>6 7
;>>7 8
}@@ 
catchAA 
(AA "
CommunicationExceptionAA )
	excepcionAA* 3
)AA3 4
{BB $
serviceBastaCodigoClientCC (
.CC( )
AbortCC) .
(CC. /
)CC/ 0
;CC0 1
StringDD 
mensajeDD 
=DD  
$strDD! 4
+DD5 6
	excepcionDD7 @
.DD@ A
MessageDDA H
;DDH I
StringEE 
tituloEE 
=EE 
$strEE  5
;EE5 6
MessageBoxButtonFF  
botonFF! &
=FF' (
MessageBoxButtonFF) 9
.FF9 :
OKFF: <
;FF< =

MessageBoxGG 
.GG 
ShowGG 
(GG  
mensajeGG  '
,GG' (
tituloGG) /
,GG/ 0
botonGG1 6
)GG6 7
;GG7 8
}HH 
}II 	
privateKK 
voidKK %
TextBoxCodigo_TextChangedKK .
(KK. /
objectKK/ 5
senderKK6 <
,KK< = 
TextChangedEventArgsKK> R
eKKS T
)KKT U
{LL 	
}NN 	
}OO 
}PP —
<C:\Users\survi\Desktop\basta\cliente\CuentaDeUsuario.xaml.cs
	namespace 	
cliente
 
{ 
public 

partial 
class 
CuentaDeUsuario (
:) *
Window+ 1
{ 
public 
CuentaDeUsuario 
( 
)  
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
Button_Click !
(! "
object" (
sender) /
,/ 0
RoutedEventArgs1 @
eA B
)B C
{ 	
InicioSesion 
ventanaInicioSesion ,
=- .
new/ 2
InicioSesion3 ?
(? @
)@ A
;A B
ventanaInicioSesion 
.  
Show  $
($ %
)% &
;& '
this   
.   
Close   
(   
)   
;   
}!! 	
private## 
void## 
Button_Click_1## #
(### $
object##$ *
sender##+ 1
,##1 2
RoutedEventArgs##3 B
e##C D
)##D E
{$$ 	
NuevaSalaEspera%% "
ventanaNuevaSalaEspera%% 2
=%%3 4
new%%5 8
NuevaSalaEspera%%9 H
(%%H I
)%%I J
;%%J K"
ventanaNuevaSalaEspera&& "
.&&" #
Show&&# '
(&&' (
)&&( )
;&&) *
this'' 
.'' 
Close'' 
('' 
)'' 
;'' 
}(( 	
private** 
void** 
Button_Click_2** #
(**# $
object**$ *
sender**+ 1
,**1 2
RoutedEventArgs**3 B
e**C D
)**D E
{++ 	
ServiceBasta,, 
.,, "
ServiceBastaSalaClient,, /
serviceInicioSesion,,0 C
=,,D E
null,,F J
;,,J K
InstanceContext// 
instanceContext// +
=//, -
new//. 1
InstanceContext//2 A
(//A B
this//B F
)//F G
;//G H
serviceInicioSesion00 
=00  !
new00" %
ServiceBasta00& 2
.002 3"
ServiceBastaSalaClient003 I
(00I J
instanceContext00J Y
)00Y Z
;00Z [
}33 	
}55 
}66 õ
9C:\Users\survi\Desktop\basta\cliente\InicioSesion.xaml.cs
	namespace 	
cliente
 
{ 
public 

partial 
class 
InicioSesion %
:& '
Window( .
{ 
public 
InicioSesion 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
Button_Click !
(! "
object" (
sender) /
,/ 0
RoutedEventArgs1 @
eA B
)B C
{ 	
ServiceBasta 
. 
ServiceLoginClient +
serviceInicioSesion, ?
=@ A
nullB F
;F G
try   
{!! 
serviceInicioSesion## #
=##$ %
new##& )
ServiceBasta##* 6
.##6 7
ServiceLoginClient##7 I
(##I J
)##J K
;##K L
string%% 
nombreDeUsuario%% &
=%%' ("
textBoxNombreDeUsuario%%) ?
.%%? @
Text%%@ D
;%%D E
string&& 

contrasena&& !
=&&" #
textBoxContrasena&&$ 5
.&&5 6
Text&&6 :
;&&: ;
bool'' !
resultadoInicioSesion'' *
;''* +!
resultadoInicioSesion)) %
=))% &
serviceInicioSesion))' :
.)): ;
InicioSesion)); G
())G H
nombreDeUsuario))H W
,))W X

contrasena))Y c
)))c d
;))d e
if++ 
(++ !
resultadoInicioSesion++ )
==++* ,
true++- 1
)++1 2
{,, 
CuentaDeUsuario-- #
cuentaDeUsuario--$ 3
=--4 5
new--6 9
CuentaDeUsuario--: I
(--I J
)--J K
;--K L
cuentaDeUsuario.. #
...# $
Show..$ (
(..( )
)..) *
;..* +
this// 
.// 
Close// 
(// 
)//  
;//  !
}00 
else11 
{22 

MessageBox33 
.33 
Show33 #
(33# $
$str33$ 7
+338 9!
resultadoInicioSesion33: O
)33O P
;33P Q
}44 
}66 
catch77 
(77 "
CommunicationException77 )
	exception77* 3
)773 4
{88 
serviceInicioSesion99 #
.99# $
Abort99$ )
(99) *
)99* +
;99+ ,

MessageBox:: 
.:: 
Show:: 
(::  
$str::  V
+::W X
	exception::Y b
)::b c
;::c d
};; 
catch<< 
(<< 
TimeoutException<< "
	exception<<# ,
)<<, -
{== 
serviceInicioSesion>> #
.>># $
Abort>>$ )
(>>) *
)>>* +
;>>+ ,

MessageBox?? 
.?? 
Show?? 
(??  
$str??  W
+??W X
	exception??Y b
)??b c
;??c d
}@@ 
finallyAA 
{BB 
serviceInicioSesionCC #
.CC# $
CloseCC$ )
(CC) *
)CC* +
;CC+ ,
}DD 
}FF 	
privateHH 
voidHH  
ButtonRegresar_ClickHH )
(HH) *
objectHH* 0
senderHH1 7
,HH7 8
RoutedEventArgsHH9 H
eHHI J
)HHJ K
{II 	

MainWindowJJ 
ventanaRegistroJJ &
=JJ' (
newJJ) ,

MainWindowJJ- 7
(JJ7 8
)JJ8 9
;JJ9 :
ventanaRegistroKK 
.KK 
ShowKK  
(KK  !
)KK! "
;KK" #
thisLL 
.LL 
CloseLL 
(LL 
)LL 
;LL 
}MM 	
}PP 
}QQ ¹
2C:\Users\survi\Desktop\basta\cliente\Lobby.xaml.cs
	namespace 	
cliente
 
{ 
public 

partial 
class 
Lobby 
:  
Window! '
{ 
public 
Lobby 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
} 
} à5
7C:\Users\survi\Desktop\basta\cliente\MainWindow.xaml.cs
	namespace 	
cliente
 
{ 
[ 
CallbackBehavior 
( %
UseSynchronizationContext /
=0 1
false2 7
)7 8
]8 9
public 

partial 
class 

MainWindow #
:$ %
Window& ,
{ 
public 

MainWindow 
( 
) 
{ 	
InitializeComponent   
(    
)    !
;  ! "
}!! 	
private## 
void## 
Button_Click## !
(##! "
object##" (
sender##) /
,##/ 0
RoutedEventArgs##1 @
e##A B
)##B C
{$$ 	
ServiceBasta%% 
.%% 
ServiceLoginClient%% +
serviceBasta%%, 8
=%%9 :
null%%; ?
;%%? @
try'' 
{(( 
serviceBasta** 
=** 
new** "
ServiceBasta**# /
.**/ 0
ServiceLoginClient**0 B
(**B C
)**C D
;**D E
string,, 
nombre,, 
=,, 
this,,  $
.,,$ %
textBoxNombre,,% 2
.,,2 3
Text,,3 7
;,,7 8
string-- 

contrasena-- !
=--" #
this--$ (
.--( )
textBoxContraseÃ±a--) :
.--: ;
Text--; ?
;--? @
string.. 
email.. 
=.. 
this.. #
...# $
textBoxEmail..$ 0
...0 1
Text..1 5
;..5 6
bool00 
resultadoRegistro00 &
=00& '
serviceBasta00( 4
.004 5
RegistrarUsuario005 E
(00E F
nombre00F L
,00L M

contrasena00N X
,00X Y
email00Z _
)00_ `
;00` a
if11 
(11 
resultadoRegistro11 %
==11& (
true11) -
)11- .
{22 
CodigoRegistro33 "!
ventanaCodigoRegistro33# 8
=339 :
new33; >
CodigoRegistro33? M
(33M N
)33N O
;33O P!
ventanaCodigoRegistro44 )
.44) *
Show44* .
(44. /
)44/ 0
;440 1
this55 
.55 
Close55 
(55 
)55  
;55  !
}99 
else:: 
{;; $
NotificarUsuarioAgregado<< ,
(<<, -
)<<- .
;<<. /
}== 
}>> 
catch?? 
(?? "
CommunicationException?? )
	exception??* 3
)??3 4
{@@ 
serviceBastaAA 
.AA 
AbortAA "
(AA" #
)AA# $
;AA$ %
StringBB 
mensajeBB 
=BB  
$strBB! F
+BBG H
	exceptionBBI R
.BBR S
MessageBBS Z
;BBZ [
StringCC 
tituloCC 
=CC 
$strCC  5
;CC5 6
MessageBoxButtonDD  
botonDD! &
=DD' (
MessageBoxButtonDD) 9
.DD9 :
OKDD: <
;DD< =

MessageBoxEE 
.EE 
ShowEE 
(EE  
mensajeEE  '
,EE' (
tituloEE) /
,EE/ 0
botonEE1 6
)EE6 7
;EE7 8
}FF 
catchGG 
(GG 
TimeoutExceptionGG #
	exceptionGG$ -
)GG- .
{HH 
serviceBastaII 
.II 
AbortII "
(II" #
)II# $
;II$ %
StringJJ 
mensajeJJ 
=JJ  
$strJJ! 4
+JJ4 5
	exceptionJJ6 ?
.JJ? @
MessageJJ@ G
;JJG H
StringKK 
tituloKK 
=KK 
$strKK  5
;KK5 6
MessageBoxButtonLL  
botonLL! &
=LL' (
MessageBoxButtonLL) 9
.LL9 :
OKLL: <
;LL< =

MessageBoxMM 
.MM 
ShowMM 
(MM  
mensajeMM  '
,MM' (
tituloMM) /
,MM/ 0
botonMM1 6
)MM6 7
;MM7 8
}NN 
finallyOO 
{PP 
ifQQ 
(QQ 
serviceBastaQQ 
!=QQ  "
nullQQ# '
)QQ' (
{RR 
ifSS 
(SS 
serviceBastaSS #
.SS# $
StateSS$ )
==SS* ,
CommunicationStateSS- ?
.SS? @
FaultedSS@ G
)SSG H
serviceBastaTT  
.TT  !
AbortTT! &
(TT& '
)TT' (
;TT( )
}UU 
elseVV 
{WW 
serviceBastaXX  
.XX  !
CloseXX! &
(XX& '
)XX' (
;XX( )
}YY 
}ZZ 
}[[ 	
private]] 
void]] 
TextBox_TextChanged]] (
(]]( )
object]]) /
sender]]0 6
,]]6 7 
TextChangedEventArgs]]8 L
e]]M N
)]]N O
{^^ 	
}`` 	
privatecc 
voidcc *
TextBoxContraseÃ±a_TextChangedcc 2
(cc2 3
objectcc3 9
sendercc: @
,cc@ A 
TextChangedEventArgsccB V
eccW X
)ccX Y
{dd 	
}ff 	
privatehh 
voidhh $
TextBoxEmail_TextChangedhh -
(hh- .
objecthh. 4
senderhh5 ;
,hh; < 
TextChangedEventArgshh= Q
ehhR S
)hhS T
{ii 	
}kk 	
privatemm 
voidmm 
Button_Click_2mm #
(mm# $
objectmm$ *
sendermm+ 1
,mm1 2
RoutedEventArgsmm3 B
emmC D
)mmD E
{nn 	
InicioSesionoo 
ventanaInicioSesionoo ,
=oo- .
newoo/ 2
InicioSesionoo3 ?
(oo? @
)oo@ A
;ooA B
ventanaInicioSesionpp 
.pp  
Showpp  $
(pp$ %
)pp% &
;pp& '
thisqq 
.qq 
Closeqq 
(qq 
)qq 
;qq 
}ss 	
publicuu 
voiduu $
NotificarUsuarioAgregadouu ,
(uu, -
)uu- .
{vv 	
Stringww 
mensajeww 
=ww 
$strww L
;wwL M
Stringxx 
tituloxx 
=xx 
$strxx #
;xx# $
MessageBoxButtonyy 
botonyy "
=yy# $
MessageBoxButtonyy% 5
.yy5 6
OKyy6 8
;yy8 9

MessageBoxzz 
.zz 
Showzz 
(zz 
mensajezz #
,zz# $
titulozz% +
,zz+ ,
botonzz- 2
)zz2 3
;zz3 4
}{{ 	
}|| 
} “2
<C:\Users\survi\Desktop\basta\cliente\NuevaSalaEspera.xaml.cs
	namespace 	
cliente
 
{ 
[ 
CallbackBehavior 
( %
UseSynchronizationContext /
=0 1
false2 7
)7 8
]8 9
public 

partial 
class 
NuevaSalaEspera (
:) *
Window+ 1
,1 2
ServiceBasta3 ?
.? @%
IServiceBastaSalaCallback@ Y
{ 
public 
NuevaSalaEspera 
( 
)  
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
public   
void   '
ImprimirUsuarioAgregadoSala   /
(  / 0
string  0 6
nombreUsuario  7 D
)  D E
{!! 	
throw"" 
new"" #
NotImplementedException"" -
(""- .
)"". /
;""/ 0
}## 	
public%% 
void%% (
NotificarUsuarioEnSalaEspera%% 0
(%%0 1
SalaDeEspera%%1 =
salaDeEspera%%> J
)%%J K
{&& 	
if(( 
((( 
salaDeEspera(( 
!=(( 
null(( #
)((# $
{)) 
foreach** 
(** 
Usuario**  
u**! "
in**# %
salaDeEspera**& 2
.**2 3
JugadoresEnEspera**3 D
)**D E
{++ 
this-- 
.-- 

Dispatcher-- #
.--# $
BeginInvoke--$ /
(--/ 0
new--0 3
ThreadStart--4 ?
(--? @
(--@ A
)--A B
=>--C E$
textboxCajaParticipantes--F ^
.--^ _
Text--_ c
=--d e
u--f g
.--g h
ToString--h p
(--p q
)--q r
)--r s
)--s t
;--t u
}.. 
String00 
mensaje00 
=00  
$str00! O
;00O P
String11 
titulo11 
=11 
$str11  ,
;11, -
MessageBoxButton22  
boton22! &
=22' (
MessageBoxButton22) 9
.229 :
OK22: <
;22< =

MessageBox33 
.33 
Show33 
(33  
mensaje33  '
,33' (
titulo33) /
,33/ 0
boton331 6
)336 7
;337 8
}55 
else66 
{77 
String88 
mensaje88 
=88  
$str88! 3
;883 4
String99 
titulo99 
=99 
$str99  ,
;99, -
MessageBoxButton::  
boton::! &
=::' (
MessageBoxButton::) 9
.::9 :
OK::: <
;::< =

MessageBox;; 
.;; 
Show;; 
(;;  
mensaje;;  '
,;;' (
titulo;;) /
,;;/ 0
boton;;1 6
);;6 7
;;;7 8
}<< 
}?? 	
privateAA 
voidAA #
ButtonAgregarSala_ClickAA ,
(AA, -
objectAA- 3
senderAA4 :
,AA: ;
RoutedEventArgsAA< K
eAAL M
)AAM N
{BB 	
ServiceBastaCC 
.CC "
ServiceBastaSalaClientCC /
serviceBastaClientCC0 B
=CCC D
nullCCE I
;CCI J
tryDD 
{EE 
InstanceContextFF 
instanceContextFF  /
=FF0 1
newFF2 5
InstanceContextFF6 E
(FFE F
thisFFF J
)FFJ K
;FFK L
serviceBastaClientGG "
=GG# $
newGG% (
ServiceBastaGG) 5
.GG5 6"
ServiceBastaSalaClientGG6 L
(GGL M
instanceContextGGM \
)GG\ ]
;GG] ^
stringII 
idII 
=II 
textboxIdSalaII (
.II( )
TextII) -
;II- .
intJJ 
idSalaJJ 
=JJ 
intJJ  
.JJ  !
ParseJJ! &
(JJ& '
idJJ' )
)JJ) *
;JJ* +
stringKK 
limiteKK 
=KK #
textboxNumParticipantesKK  7
.KK7 8
TextKK8 <
;KK< =
stringLL 
nombreAnfitrionLL &
=LL' ( 
textboxNombreUsuarioLL) =
.LL= >
TextLL> B
;LLB C
intOO 
numParticipantesOO $
=OO% &
intOO' *
.OO* +
ParseOO+ 0
(OO0 1
limiteOO1 7
)OO7 8
;OO8 9
serviceBastaClientQQ "
.QQ" #
CrearSalaEsperaQQ# 2
(QQ2 3
idSalaQQ3 9
,QQ9 :
numParticipantesQQ; K
,QQK L
nombreAnfitrionQQM \
)QQ\ ]
;QQ] ^
}RR 
catchSS 
(SS "
CommunicationExceptionSS )
	excepcionSS* 3
)SS3 4
{TT 
serviceBastaClientUU "
.UU" #
AbortUU# (
(UU( )
)UU) *
;UU* +

MessageBoxVV 
.VV 
ShowVV 
(VV  
$strVV  +
+VV, -
	excepcionVV. 7
.VV7 8
MessageVV8 ?
)VV? @
;VV@ A
}WW 
catchXX 
(XX 
TimeoutExceptionXX "
	excepcionXX# ,
)XX, -
{YY 
serviceBastaClientZZ "
.ZZ" #
AbortZZ# (
(ZZ( )
)ZZ) *
;ZZ* +

MessageBox[[ 
.[[ 
Show[[ 
([[  
$str[[  +
+[[, -
	excepcion[[. 7
.[[7 8
Message[[8 ?
)[[? @
;[[@ A
}\\ 
finally]] 
{^^ 
if__ 
(__ 
serviceBastaClient__ &
!=__' )
null__* .
)__. /
{`` 
ifaa 
(aa 
serviceBastaClientaa *
.aa* +
Stateaa+ 0
==aa1 3
CommunicationStateaa4 F
.aaF G
FaultedaaG N
)aaN O
serviceBastaClientcc *
.cc* +
Abortcc+ 0
(cc0 1
)cc1 2
;cc2 3
}dd 
elseee 
{ff 
serviceBastaClientgg &
.gg& '
Closegg' ,
(gg, -
)gg- .
;gg. /
}hh 
}ii 
}jj 	
}kk 
}ll †
?C:\Users\survi\Desktop\basta\cliente\Properties\AssemblyInfo.cs
[

 
assembly

 	
:

	 

AssemblyTitle

 
(

 
$str

 "
)

" #
]

# $
[ 
assembly 	
:	 

AssemblyDescription 
( 
$str !
)! "
]" #
[ 
assembly 	
:	 
!
AssemblyConfiguration  
(  !
$str! #
)# $
]$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str 
) 
] 
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str $
)$ %
]% &
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
["" 
assembly"" 	
:""	 

	ThemeInfo"" 
("" &
ResourceDictionaryLocation## 
.## 
None## #
,### $&
ResourceDictionaryLocation&& 
.&& 
SourceAssembly&& -
))) 
])) 
[66 
assembly66 	
:66	 

AssemblyVersion66 
(66 
$str66 $
)66$ %
]66% &
[77 
assembly77 	
:77	 

AssemblyFileVersion77 
(77 
$str77 (
)77( )
]77) *