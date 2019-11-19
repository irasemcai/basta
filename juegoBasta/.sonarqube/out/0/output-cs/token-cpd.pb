π	
8C:\Users\survi\Desktop\basta\juegoBasta\CompositeType.cs
	namespace 	

juegoBasta
 
{ 
[ 
DataContract 
] 
public 

class 
CompositeType 
{		 
bool

 
	boolValue

 
=

 
true

 
;

 
string 
stringValue 
= 
$str %
;% &
[ 	

DataMember	 
] 
public 
bool 
	BoolValue 
{ 	
get 
{ 
return 
	boolValue "
;" #
}$ %
set 
{ 
	boolValue 
= 
value #
;# $
}% &
} 	
[ 	

DataMember	 
] 
public 
string 
StringValue !
{ 	
get 
{ 
return 
stringValue $
;$ %
}& '
set 
{ 
stringValue 
= 
value  %
;% &
}' (
} 	
} 
} Ó
@C:\Users\survi\Desktop\basta\juegoBasta\Domain\ClaseAbstracta.cs
	namespace 	

juegoBasta
 
. 
Domain 
{ 
public		 	
abstract		
 
class		 
ClaseAbstracta		 '
<		' (
T		( )
>		) *
{

 
	protected 
bastaEntities 
	entidades  )
;) *
public 
ClaseAbstracta 
( 
) 
{ 	
Init 
( 
) 
; 
} 	
public 
void 
Init 
( 
) 
{ 	
	entidades 
= 
new 
bastaEntities )
() *
)* +
;+ ,
} 	
public 
abstract 
int 
AgregarEntidad *
(+ ,
T, -
entidad. 5
)5 6
;6 7
} 
} ﬁ
?C:\Users\survi\Desktop\basta\juegoBasta\Domain\MensajeCorreo.cs
	namespace		 	

juegoBasta		
 
.		 
Domain		 
{

 
public 	
class
 
MensajeCorreo 
{ 
public 
bool 
EnviarCorreo  
(  !
string! '
correoDestinatario( :
,: ;
int< ?
codigo@ F
)F G
{ 	
MailAddress 
CorreoBasta #
=$ %
new& )
MailAddress* 5
(5 6
$str6 L
)L M
;M N
MailAddress 
CorreoDestino %
=& '
new( +
MailAddress, 7
(7 8
correoDestinatario8 J
)J K
;K L
MailMessage 
mailMessage #
=$ %
new& )
MailMessage* 5
(5 6
)6 7
;7 8
mailMessage 
. 
From 
= 
CorreoBasta *
;* +
mailMessage 
. 
To 
. 
Add 
( 
CorreoDestino ,
), -
;- .
mailMessage 
. 
Subject 
=  !
$str" E
+F G
DateTimeH P
.P Q
NowQ T
.T U
ToStringU ]
(] ^
$str^ x
)x y
;y z
mailMessage 
. 
Body 
= 
$str ;
+; <
codigo= C
;C D
mailMessage 
. 
Priority  
=! "
MailPriority# /
./ 0
Normal0 6
;6 7

SmtpClient 
stmp 
= 
new !

SmtpClient" ,
(, -
)- .
;. /
stmp 
. 
Host 
= 
$str (
;( )
stmp   
.   
Port   
=   
$num   
;   
stmp!! 
.!! 
Credentials!! 
=!! 
new!! "
NetworkCredential!!# 4
(!!4 5
$str!!5 K
,!!K L
$str!!M ^
)!!^ _
;!!_ `
stmp"" 
."" 
	EnableSsl"" 
="" 
true"" !
;""! "
try%% 
{&& 
stmp'' 
.'' 
Send'' 
('' 
mailMessage'' %
)''% &
;''& '
mailMessage(( 
.(( 
Dispose(( #
(((# $
)(($ %
;((% &
return++ 
true++ 
;++ 
},, 
catch,, 
(,, 
	Exception,, 
	excepcion,, '
),,' (
{-- 
string.. 
	resultado.. 
=..  !
$str.." +
+.., -
	excepcion... 7
...7 8
Message..8 ?
;..? @
return// 
false// 
;// 
}00 
}22 	
}88 
}99 ü)
>C:\Users\survi\Desktop\basta\juegoBasta\Domain\SalaDeEspera.cs
	namespace		 	

juegoBasta		
 
.		 
Domain		 
{

 
[ 
DataContract 
] 
public 

class 
SalaDeEspera 
{ 
	protected 
int 
idSala 
; 
	protected 
string 
estado 
;  
public 
List 
< 
Usuario 
> 
jugadoresEnEspera .
;. /
	protected 
int 
limiteJugadores %
;% &
	protected 
Usuario 
	anfitrion #
;# $
public 
SalaDeEspera 
( 
int 
id !
,! "
string# )
estado* 0
,0 1
List2 6
<6 7
Usuario7 >
>> ?
usuarios@ H
,H I
intJ M
limiteJugadoresN ]
,] ^
Usuario_ f
	anfitriong p
)p q
{ 	
this 
. 
IdSala 
= 
id 
; 
this 
. 
estado 
= 
estado  
;  !
this 
. 
JugadoresEnEspera "
=# $
usuarios% -
;- .
this 
. 
limiteJugadores  
=! "
limiteJugadores# 2
;2 3
this 
. 
	anfitrion 
= 
	anfitrion &
;& '
} 	
[ 	

DataMember	 
] 
public 
int 
IdSala 
{ 	
get   
{   
return   
idSala   
;    
}  ! "
set!! 
{!! 
idSala!! 
=!! 
value!!  
;!!  !
}!!" #
}"" 	
[$$ 	

DataMember$$	 
]$$ 
	protected%% 
string%% 
Estado%% 
{%%  !
get&& 
{&& 
return&& 
estado&& 
;&&  
}&&! "
set'' 
{'' 
estado'' 
='' 
value''  
;''  !
}''" #
}(( 	
[)) 	

DataMember))	 
])) 
public** 
List** 
<** 
Usuario** 
>** 
JugadoresEnEspera** .
{**/ 0
get++ 
{++ 
return++ 
jugadoresEnEspera++ *
;++* +
}++, -
set,, 
{,, 
jugadoresEnEspera,, #
=,,$ %
value,,& +
;,,+ ,
},,- .
}-- 	
[.. 	

DataMember..	 
].. 
private// 
int// 
LimiteJugadores// #
{//$ %
get00 
{00 
return00 
limiteJugadores00 (
;00( )
}00* +
set11 
{11 
limiteJugadores11 !
=11" #
value11$ )
;11) *
}11+ ,
}22 	
[33 	

DataMember33	 
]33 
private44 
Usuario44 
	Anfitrion44 !
{44" #
get55 
{55 
return55 
	anfitrion55 "
;55" #
}55$ %
set66 
{66 
	anfitrion66 
=66 
value66 #
;66# $
}66% &
}77 	
}88 
public;; 

class;; 
ControladorSala;;  
{;;! "
public== 
SalaDeEspera== 
CrearSalaDeEspera== -
(==- .
int==. 1
id==2 4
,==4 5
int==6 9
limiteJugadores==: I
,==I J
Usuario==K R
	anfitrion==S \
)==\ ]
{>> 	
string?? 
estado?? 
=?? 
$str?? (
;??( )
id@@ 
=@@ 
$num@@ 
;@@ 
ListAA 
<AA 
UsuarioAA 
>AA 
usuariosAA "
=AA# $
newAA% (
ListAA) -
<AA- .
UsuarioAA. 5
>AA5 6
(AA6 7
limiteJugadoresAA7 F
)AAF G
;AAG H
SalaDeEsperaBB 
salaDeEsperaBB %
=BB& '
newBB( +
SalaDeEsperaBB, 8
(BB9 :
idBB: <
,BB< =
estadoBB> D
,BBD E
usuariosBBF N
,BBN O
limiteJugadoresBBP _
,BB_ `
	anfitrionBBa j
)BBj k
;BBk l
salaDeEsperaCC 
.CC 
JugadoresEnEsperaCC *
.CC* +
AddCC+ .
(CC. /
	anfitrionCC/ 8
)CC8 9
;CC9 :
returnEE 
salaDeEsperaEE 
;EE  
}GG 	
publicII 
ListII 
<II 
SalaDeEsperaII  
>II  !#
ObtenerSalasDisponiblesII" 9
(II9 :
)II: ;
{JJ 	
returnVV 
nullVV 
;VV 
}WW 	
}tt 
}uu ®
9C:\Users\survi\Desktop\basta\juegoBasta\Domain\Usuario.cs
	namespace 	

juegoBasta
 
. 
Domain 
{ 
public		 

class		 
Usuario		 
:		 
ClaseAbstracta		 )
<		) *
user		* .
>		. /
{

 
private 
user 
user 
; 
public 
Usuario 
( 
) 
{ 	
} 	
public 
Usuario 
( 
user 
user  
)  !
{ 	
this 
. 
user 
= 
user 
; 
} 	
public 
override 
int 
AgregarEntidad *
(+ ,
user, 0
entidad1 8
)8 9
{ 	
int 
	resultado 
; 
	entidades 
. 
users 
. 
Add 
(  
entidad  '
)' (
;( )
	resultado 
= 
	entidades !
.! "
SaveChanges" -
(- .
). /
;/ 0
return 
	resultado 
; 
} 	
public   
bool   
IniciarSesion   !
(  ! "
string  " (
nombreUsuario  ) 6
,  6 7
string  8 >

contrasena  ? I
)  I J
{!! 	
bool"" 
	resultado"" 
="" 
	entidades"" &
.""& '
users""' ,
."", -
Any""- 0
(""0 1
x""1 2
=>""3 5
x""6 7
.""7 8
name""8 <
==""= ?
nombreUsuario""@ M
&&""N P
x""Q R
.""R S
password""S [
==""\ ^

contrasena""_ i
)""i j
;""j k
if## 
(## 
	resultado## 
)## 
{$$ 
return&& 
	resultado&&  
;&&  !
}'' 
else(( 
{)) 
return** 
false** 
;** 
}++ 
},, 	
public.. 
Usuario.. #
ObtenerUsuarioPorNombre.. .
(... /
string../ 5
nombre..6 <
)..< =
{// 	
bool00 
	resultado00 
=00 
	entidades00 &
.00& '
users00' ,
.00, -
Any00- 0
(000 1
x001 2
=>003 5
x006 7
.007 8
name008 <
==00= ?
nombre00@ F
)00F G
;00G H
if11 
(11 
	resultado11 
)11 
{22 
user33 
user33 
=33 
	entidades33 "
.33" #
users33# (
.33( )
Find33) -
(33- .
nombre33. 4
)334 5
;335 6
Usuario44 
usuario44 
=44  !
new44" %
Usuario44& -
(44- .
user44. 2
)442 3
;443 4
return55 
usuario55 
;55 
}66 
else77 
{88 
return99 
null99 
;99 
}:: 
}<< 	
}== 
}>> ‡
>C:\Users\survi\Desktop\basta\juegoBasta\IServiceBastaCodigo.cs
	namespace 	

juegoBasta
 
{ 
[ 
ServiceContract 
] 
	interface 
IServiceBastaCodigo !
{ 
[ 	
OperationContract	 
] 
bool		 #
VerificarCodigoRegistro		 $
(		$ %
int		% (
codigo		) /
)		/ 0
;		0 1
} 
} Ã
<C:\Users\survi\Desktop\basta\juegoBasta\IServiceBastaSala.cs
	namespace 	

juegoBasta
 
{ 
[ 
ServiceContract 
( 
CallbackContract %
=& '
typeof( .
(. /
IBastaSalaCallback/ A
)A B
)B C
]C D
	interface 
IServiceBastaSala 
{ 
[		 	
OperationContract			 
(		 
IsOneWay		 #
=		$ %
true		& *
)		* +
]		+ ,
void

 
CrearSalaEspera

 
(

 
int

  
id

! #
,

# $
int

% (
limiteParticipantes

) <
,

< =
string

> D
	anfitrion

E N
)

N O
;

O P
[ 	
OperationContract	 
( 
IsOneWay #
=$ %
true& *
)* +
]+ ,
void 
UnirseASala 
( 
string 
nombreUsuario  -
)- .
;. /
[ 	
OperationContract	 
] 
Usuario "
BuscarUsuarioPorNombre &
(& '
string' -
nombre. 4
)4 5
;5 6
} 
	interface 
IBastaSalaCallback  
{ 
[ 	
OperationContract	 
( 
IsOneWay #
=$ %
true& *
)* +
]+ ,
void (
NotificarUsuarioEnSalaEspera )
() *
SalaDeEspera* 6
salaDeEspera7 C
)C D
;D E
[ 	
OperationContract	 
( 
IsOneWay #
=$ %
true& *
)* +
]+ ,
void '
ImprimirUsuarioAgregadoSala (
(( )
string) /
nombreUsuario0 =
)= >
;> ?
} 
} ô
8C:\Users\survi\Desktop\basta\juegoBasta\IServiceLogin.cs
	namespace 	

juegoBasta
 
{ 
[ 
ServiceContract 
] 
	interface 
IServiceLogin 
{ 
[		 	
OperationContract			 
]		 
bool

 
InicioSesion

 
(

 
string

  
nombre

! '
,

' (
string

) /

contrasena

0 :
)

: ;
;

; <
[ 	
OperationContract	 
] 
bool 
RegistrarUsuario 
( 
string $
name% )
,) *
string+ 1
password2 :
,: ;
string< B
emailC H
)H I
;I J
[ 	
OperationContract	 
]  
ObservableCollection 
< 
string #
># $%
ObtenerUsuariosConectados% >
(> ?
)? @
;@ A
} 
} Ì
BC:\Users\survi\Desktop\basta\juegoBasta\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str %
)% &
]& '
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 !
)		! "
]		" #
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str 
) 
] 
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str '
)' (
]( )
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
[## 
assembly## 	
:##	 

AssemblyVersion## 
(## 
$str## $
)##$ %
]##% &
[$$ 
assembly$$ 	
:$$	 

AssemblyFileVersion$$ 
($$ 
$str$$ (
)$$( )
]$$) *◊Z
7C:\Users\survi\Desktop\basta\juegoBasta\ServiceBasta.cs
	namespace

 	

juegoBasta


 
{ 
[ 
ServiceBehavior 
( 
ConcurrencyMode $
=% &
ConcurrencyMode' 6
.6 7
Single7 =
,= >
InstanceContextMode? R
=S T
InstanceContextModeU h
.h i
Singlei o
)o p
]p q
public 

class 
ServiceBasta 
: 
IServiceBastaCodigo  3
,3 4
IServiceLogin5 B
,C D
IServiceBastaSalaE V
{ 
Type 
providerService 
= 
typeof %
(% &
System& ,
., -
Data- 1
.1 2
Entity2 8
.8 9
	SqlServer9 B
.B C
SqlProviderServicesC V
)V W
;W X
private 

Dictionary 
< 
string !
,! "
int# &
>& '
nuevosUsuarios( 6
=7 8
new9 <

Dictionary= G
<G H
stringH N
,N O
intP S
>S T
(T U
)U V
;V W 
ObservableCollection 
< 
String #
># $
usuariosConectados% 7
=8 9
new: = 
ObservableCollection> R
<R S
stringS Y
>Y Z
(Z [
)[ \
;\ ]
public 
bool 
RegistrarUsuario $
(% &
string& ,
name- 1
,1 2
string3 9
password: B
,B C
stringD J
emailK P
)P Q
{ 	
Usuario 
usuario 
= 
new !
Usuario" )
() *
)* +
;+ ,
user 
user 
= 
new 
user  
(  !
)! "
;" #
MensajeCorreo 
mensajeCorreo '
=( )
new* -
MensajeCorreo. ;
(; <
)< =
;= >
Random 
random 
= 
new 
Random  &
(& '
)' (
;( )
int 
codigoRegistro 
=  
random! '
.' (
Next( ,
(, -
$num- 0
,0 1
$num2 5
)5 6
;6 7
user   
.   
name   
=   
name   
;   
user!! 
.!! 
password!! 
=!! 
password!! $
;!!$ %
user"" 
."" 
email"" 
="" 
email"" 
;"" 
int## 
resultadoRegistro## !
=##" #
usuario##$ +
.##+ ,
AgregarEntidad##, :
(##: ;
user##; ?
)##? @
;##@ A
if$$ 
($$ 
resultadoRegistro$$ !
==$$" $
$num$$% &
)$$& '
{%% 
bool&& 
resultadoCorreo&& $
=&&% &
mensajeCorreo&&' 4
.&&4 5
EnviarCorreo&&5 A
(&&A B
email&&B G
,&&G H
codigoRegistro&&I W
)&&W X
;&&X Y
if'' 
('' 
resultadoCorreo'' #
==''# %
true''% )
)'') *
{(( 
nuevosUsuarios)) "
.))" #
Add))# &
())& '
name))' +
,))+ ,
codigoRegistro))- ;
))); <
;))< =
}++ 
Console-- 
.-- 
	WriteLine-- !
(--! "
$"--" $
{--$ %
email--% *
}--* +3
' se ha registrado. Resultado registro: --+ R
{--R S
resultadoRegistro--S d
}--d e!
 ,Resultado correo:  --e z
{--z {
resultadoCorreo	--{ ä
}
--ä ã
"
--ã å
)
--å ç
;
--ç é
return.. 
true.. 
;.. 
}// 
else00 
{11 
Console22 
.22 
	WriteLine22 !
(22! "
$"22" $
{22$ %
email22% *
}22* +=
1 se ha intent√≥ registrarse. Resultado registro: 22+ [
{22[ \
resultadoRegistro22\ m
}22m n
"22n o
)22o p
;22p q
return33 
false33 
;33 
}44 
}66 	
public99 
Usuario99 "
BuscarUsuarioPorNombre99 -
(99- .
string99. 4
nombre995 ;
)99; <
{:: 	
Usuario<< 
usuario<< 
=<< 
new<< !
Usuario<<" )
(<<) *
)<<* +
;<<+ ,
Usuario== 
user== 
;== 
user>> 
=>> 
usuario>> 
.>> #
ObtenerUsuarioPorNombre>> 2
(>>2 3
nombre>>3 9
)>>9 :
;>>: ;
return@@ 
user@@ 
;@@ 
}AA 	
publicCC 
voidCC 
CrearSalaEsperaCC #
(CC# $
intCC$ '
idCC( *
,CC* +
intCC, /
limiteParticipantesCC0 C
,CCC D
stringCCE K
	anfitrionCCL U
)CCU V
{DD 	
IBastaSalaCallbackFF 
bastaSalaCallbabkFF 0
=FF1 2
OperationContextFF3 C
.FFC D
CurrentFFD K
.FFK L
GetCallbackChannelFFL ^
<FF^ _
IBastaSalaCallbackFF_ q
>FFq r
(FFr s
)FFs t
;FFt u
UsuarioII 
usuarioAnfitrionII $
;II$ %
usuarioAnfitrionJJ 
=JJ "
BuscarUsuarioPorNombreJJ 5
(JJ5 6
	anfitrionJJ6 ?
)JJ? @
;JJ@ A
ControladorSalaKK 
controladorSalaKK +
=KK, -
newKK. 1
ControladorSalaKK2 A
(KKA B
)KKB C
;KKC D
SalaDeEsperaLL 
salaDeEsperaLL %
=LL% &
controladorSalaLL' 6
.LL6 7
CrearSalaDeEsperaLL7 H
(LLH I
idLLI K
,LLK L
limiteParticipantesLLM `
,LL` a
usuarioAnfitrionLLb r
)LLr s
;LLs t
ifMM 
(MM 
salaDeEsperaMM 
!=MM 
nullMM "
)MM" #
{MM# $
ConsoleNN 
.NN 
	WriteLineNN !
(NN! "
$"NN" $
{NN$ %
	anfitrionNN% .
}NN. /
 ha creado Sala: NN/ @
{NN@ A
salaDeEsperaNNA M
.NNM N
ToStringNNN V
(NNV W
)NNW X
}NNX Y
"NNZ [
)NN[ \
;NN\ ]
}PP 
elseQQ 
{RR 
ConsoleSS 
.SS 
	WriteLineSS !
(SS! "
$"SS" $
{SS$ %
	anfitrionSS% .
}SS. //
# ha INTENTADO crear una Sala: null SS/ R
{SSR S
salaDeEsperaSSS _
.SS_ `
ToStringSS` h
(SSh i
)SSi j
}SSj k
"SSl m
)SSm n
;SSn o
}UU 
bastaSalaCallbabkWW !
.WW! "(
NotificarUsuarioEnSalaEsperaWW" >
(WW> ?
salaDeEsperaWW? K
)WWK L
;WWL M
}XX 	
public[[ 
bool[[ 
InicioSesion[[  
([[  !
string[[! '
nombre[[( .
,[[. /
string[[0 6

contrasena[[7 A
)[[A B
{\\ 	
Usuario]] 
usuario]] 
=]] 
new]] !
Usuario]]" )
(]]) *
)]]* +
;]]+ ,
bool^^ 
	resultado^^ 
=^^ 
usuario^^ $
.^^$ %
IniciarSesion^^% 2
(^^2 3
nombre^^3 9
,^^9 :

contrasena^^; E
)^^E F
;^^F G
if__ 
(__ 
	resultado__ 
)__ 
{`` 
Consoleaa 
.aa 
	WriteLineaa !
(aa! "
$"aa" $
{aa$ %
nombreaa% +
}aa+ ,
 se ha conectadoaa, <
"aa< =
)aa= >
;aa> ?
usuariosConectadosbb "
.bb" #
Addbb# &
(bb& '
nombrebb' -
)bb- .
;bb. /
returncc 
truecc 
;cc 
}dd 
elseee 
{ff 
returngg 
falsegg 
;gg 
}hh 
}ii 	
publicll 
voidll 
UnirseASalall 
(ll  
stringll  &
nombreUsuarioll' 4
)ll4 5
{mm 	

Dictionarynn 
<nn 
IBastaSalaCallbacknn )
,nn) *
stringnn+ 1
>nn1 2
usuariosnn3 ;
=nn< =
newnn> A

DictionarynnB L
<nnL M
IBastaSalaCallbacknnM _
,nn_ `
stringnna g
>nng h
(nnh i
)nni j
;nnj k
varoo 
conexionoo 
=oo 
OperationContextoo +
.oo+ ,
Currentoo, 3
.oo3 4
GetCallbackChanneloo4 F
<ooF G
IBastaSalaCallbackooG Y
>ooY Z
(ooZ [
)oo[ \
;oo\ ]
usuariosrr 
[rr 
conexionrr 
]rr 
=rr  
nombreUsuariorr! .
;rr. /
Consolett 
.tt 
	WriteLinett 
(tt 
$"tt  
{tt  !
nombreUsuariott! .
}tt. /
 se ha unido a salatt/ B
"ttB C
)ttC D
;ttD E
}ww 	
publicyy 
boolyy #
VerificarCodigoRegistroyy +
(yy+ ,
intyy, /
codigoyy0 6
)yy6 7
{zz 	
foreach|| 
(|| 
string|| 
usuario|| #
in||$ &
nuevosUsuarios||' 5
.||5 6
Keys||6 :
)||: ;
{}} 
if~~ 
(~~ 
nuevosUsuarios~~ &
[~~& '
usuario~~' .
]~~. /
.~~/ 0
Equals~~0 6
(~~6 7
codigo~~7 =
)~~= >
)~~> ?
{  
usuariosConectados
ÄÄ *
.
ÄÄ* +
Add
ÄÄ+ .
(
ÄÄ. /
usuario
ÄÄ/ 6
)
ÄÄ6 7
;
ÄÄ7 8
Console
ÅÅ 
.
ÅÅ 
	WriteLine
ÅÅ %
(
ÅÅ% &
$"
ÅÅ& (
{
ÅÅ( )
usuario
ÅÅ) 0
}
ÅÅ0 1:
, ha completado su registro e inici√≥ sesi√≥n
ÅÅ1 [
"
ÅÅ[ \
)
ÅÅ\ ]
;
ÅÅ] ^
return
ÇÇ 
true
ÇÇ #
;
ÇÇ# $
}
ÉÉ 
}
ÑÑ 
return
ÖÖ 
false
ÖÖ 
;
ÖÖ 
}
ÜÜ 
public
àà "
ObservableCollection
àà #
<
àà# $
string
àà$ *
>
àà* +'
ObtenerUsuariosConectados
àà, E
(
ààE F
)
ààF G
{
ââ 	
Console
ää 
.
ää 
	WriteLine
ää 
(
ää 
$"
ää  
{
ää  ! 
usuariosConectados
ää! 3
}
ää3 4
 now
ää4 8
"
ää8 9
)
ää9 :
;
ää: ;
return
ãã  
usuariosConectados
ãã %
;
ãã% &
}
åå 	
}
çç 
}éé 