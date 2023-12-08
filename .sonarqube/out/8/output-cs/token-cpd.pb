�
WD:\DotNetCore\DotNetCoreAPI\BusinessOperations\Implementations\BaseBusinessOperation.cs
	namespace 	
BusinessOperations
 
. 
Implementations ,
{		 
public 

abstract 
class !
BaseBusinessOperation /
{ 
private 
IServiceProvider  
_serviceProvider! 1
{ 	
get 
{ 
return 
ServiceHelpers %
.% &
GetServiceProvider& 8
(8 9
)9 :
;: ;
} 
} 	
	protected   
readonly   
ILogger   "
logger  # )
;  ) *
	protected%% 
readonly%%  
IHttpContextAccessor%% /
httpContextAccessor%%0 C
;%%C D
	protected** 
readonly** 
IMapper** "
mapper**# )
;**) *
	protected// !
BaseBusinessOperation// '
(//' (
)//( )
{00 	
if11 
(11 
this11 
.11 
logger11 
==11 
null11 #
)11# $
{22 
this33 
.33 
logger33 
=33 
this33 "
.33" #
_serviceProvider33# 3
.333 4
GetRequiredService334 F
<33F G
ILogger33G N
>33N O
(33O P
)33P Q
;33Q R
}44 
if66 
(66 
this66 
.66 
httpContextAccessor66 (
==66) +
null66, 0
)660 1
{77 
this88 
.88 
httpContextAccessor88 (
=88) *
ServiceHelpers88+ 9
.889 :"
GetHttpContextAccessor88: P
(88P Q
)88Q R
;88R S
}99 
if;; 
(;; 
this;; 
.;; 
mapper;; 
==;; 
null;; #
);;# $
{<< 
this== 
.== 
mapper== 
=== 
ServiceHelpers== ,
.==, -
	GetMapper==- 6
(==6 7
)==7 8
;==8 9
}>> 
}?? 	
	protectedEE !
BaseBusinessOperationEE '
(EE' (
IMapperEE( /
mapperEE0 6
)EE6 7
:EE8 9
thisEE: >
(EE> ?
)EE? @
{FF 	
thisGG 
.GG 
mapperGG 
=GG 
mapperGG  
;GG  !
}HH 	
}II 
}JJ �
OD:\DotNetCore\DotNetCoreAPI\BusinessOperations\Implementations\BOSubCategory.cs
	namespace 	
BusinessOperations
 
. 
Implementations ,
{		 
public 

class 
BOSubCategory 
:  !
BaseBusinessOperation! 6
,6 7
IBOSubCategory8 F
{ 
private 
readonly 
ISubCategoryService ,
_subCategoryService- @
;@ A
public 
BOSubCategory 
( 
ISubCategoryService 0
subCategoryService1 C
)C D
:E F
baseG K
(K L
)L M
{ 	
this 
. 
_subCategoryService $
=% &
subCategoryService' 9
;9 :
} 	
public%% ,
 UserSubCategoryDetailInformation%% /
Get%%0 3
(%%3 4
int%%4 7
id%%8 :
)%%: ;
{&& 	
this'' 
.'' 
logger'' 
.'' 
Debug'' 
('' 
$str'' \
)''\ ]
;''] ^
SubCategory)) 
subCategory)) #
=))$ %
this))& *
.))* +
_subCategoryService))+ >
.))> ?
Get))? B
())B C
id))C E
)))E F
;))F G
if** 
(** 
subCategory** 
==** 
null** #
)**# $
{++ 
throw,, 
new,, 
LevelsUpException,, +
(,,+ ,
ErrorMessages,,, 9
.,,9 :#
SUB_CATEGORY_NOT_EXISTS,,: Q
,,,Q R

ErrorCodes,,S ]
.,,] ^
NotFound,,^ f
,,,f g
id,,h j
),,j k
;,,k l
}-- ,
 UserSubCategoryDetailInformation// ,,
 userSubCategoryDetailInformation//- M
=//N O
this//P T
.//T U
mapper//U [
.//[ \
Map//\ _
<//_ `-
 UserSubCategoryDetailInformation	//` �
>
//� �
(
//� �
subCategory
//� �
)
//� �
;
//� �
this11 
.11 
logger11 
.11 
Debug11 
(11 
$str11 Z
)11Z [
;11[ \
return33 ,
 userSubCategoryDetailInformation33 3
;333 4
}44 	
}55 
}66 ��
HD:\DotNetCore\DotNetCoreAPI\BusinessOperations\Implementations\BOUser.cs
	namespace 	
BusinessOperations
 
. 
Implementations ,
{ 
public 

class 
BOUser 
: !
BaseBusinessOperation /
,/ 0
IBOUser1 8
{   
private%% 
readonly%% 
IUserProfileService%% ,
_userProfileService%%- @
;%%@ A
private** 
readonly** 
ITwillioService** (
_twillioService**) 8
;**8 9
private// 
readonly// 
IUserService// %
_userService//& 2
;//2 3
private44 
readonly44 
IEmailService44 &
_emailService44' 4
;444 5
private99 
readonly99 
UserManager99 $
<99$ %
LevelsUpUser99% 1
>991 2
_userManager993 ?
;99? @
private>> 
readonly>> 
SignInManager>> &
<>>& '
LevelsUpUser>>' 3
>>>3 4
_signInManager>>5 C
;>>C D
privateCC 
readonlyCC  
JsonWebTokenSettingsCC - 
_jsonWebTokenSettingCC. B
;CCB C
privateHH 
readonlyHH #
JwtSecurityTokenHandlerHH 0$
_jwtSecurityTokenHandlerHH1 I
;HHI J
publicWW 
BOUserWW 
(WW 
IUserProfileServiceWW )
userProfileServiceWW* <
,WW< =
ITwillioServiceWW> M
twillioServiceWWN \
,WW\ ]
IUserServiceWW^ j
userServiceWWk v
,WWv w
IEmailService	WWx �
emailService
WW� �
,
WW� �
UserManager
WW� �
<
WW� �
LevelsUpUser
WW� �
>
WW� �
userManager
WW� �
,
WW� �
SignInManagerXX 
<XX 
LevelsUpUserXX &
>XX& '
signInManagerXX( 5
,XX5 6 
JsonWebTokenSettingsXX7 K
jsonWebTokenSettingXXL _
,XX_ `#
JwtSecurityTokenHandlerXXa x$
jwtSecurityTokenHandler	XXy �
)
XX� �
:
XX� �
base
XX� �
(
XX� �
)
XX� �
{YY 	
thisZZ 
.ZZ 
_userProfileServiceZZ $
=ZZ% &
userProfileServiceZZ' 9
;ZZ9 :
this[[ 
.[[ 
_twillioService[[  
=[[! "
twillioService[[# 1
;[[1 2
this\\ 
.\\ 
_userService\\ 
=\\ 
userService\\  +
;\\+ ,
this]] 
.]] 
_emailService]] 
=]]  
emailService]]! -
;]]- .
this^^ 
.^^ 
_userManager^^ 
=^^ 
userManager^^  +
;^^+ ,
this__ 
.__ 
_signInManager__ 
=__  !
signInManager__" /
;__/ 0
this`` 
.``  
_jsonWebTokenSetting`` %
=``& '
jsonWebTokenSetting``( ;
;``; <
thisaa 
.aa $
_jwtSecurityTokenHandleraa )
=aa* +#
jwtSecurityTokenHandleraa, C
;aaC D
}bb 	
publicmm 
asyncmm 
Taskmm 
<mm 
boolmm 
>mm 
RegisterUserAsyncmm  1
(mm1 2
RegisterRequestmm2 A
registerRequestmmB Q
,mmQ R
	UserRolesmmS \
userRolemm] e
)mme f
{nn 	
booloo 
IsRegisteredoo 
=oo 
falseoo  %
;oo% &
thisqq 
.qq 
loggerqq 
.qq 
Debugqq 
(qq 
$"qq  -
!Checking the user with the email qq  A
{qqA B
registerRequestqqB Q
.qqQ R
EmailqqR W
}qqW X
 in the systemqqX f
"qqf g
)qqg h
;qqh i
LevelsUpUserss 
dbUserss 
=ss  !
awaitss" '
thisss( ,
.ss, -
_userManagerss- 9
.ss9 :
FindByEmailAsyncss: J
(ssJ K
registerRequestssK Z
.ssZ [
Emailss[ `
)ss` a
;ssa b
iftt 
(tt 
dbUsertt 
!=tt 
nulltt 
)tt 
{uu 
throwvv 
newvv 
LevelsUpExceptionvv +
(vv+ ,
ErrorMessagesvv, 9
.vv9 :
USER_ALREADY_EXISTvv: L
,vvL M

ErrorCodesvvN X
.vvX Y
NotFoundvvY a
)vva b
;vvb c
}ww 
thisyy 
.yy 
loggeryy 
.yy 
Debugyy 
(yy 
$"yy  8
,User not exist in the system with the email yy  L
{yyL M
registerRequestyyM \
.yy\ ]
Emailyy] b
}yyb c
"yyc d
)yyd e
;yye f
LevelsUpUser{{ 
user{{ 
={{ 
this{{  $
.{{$ %
mapper{{% +
.{{+ ,
Map{{, /
<{{/ 0
LevelsUpUser{{0 <
>{{< =
({{= >
registerRequest{{> M
){{M N
;{{N O
this}} 
.}} 
logger}} 
.}} 
Debug}} 
(}} 
$str}} B
)}}B C
;}}C D
IdentityResult~~ 
result~~ !
=~~" #
await~~$ )
this~~* .
.~~. /
_userManager~~/ ;
.~~; <
CreateAsync~~< G
(~~G H
user~~H L
,~~L M
registerRequest~~N ]
.~~] ^
Password~~^ f
)~~f g
;~~g h
if 
( 
! 
result 
. 
	Succeeded !
)! "
{
�� 
throw
�� 
new
�� 
LevelsUpException
�� +
(
��+ ,
ErrorMessages
��, 9
.
��9 :
USER_NOT_CREATED
��: J
,
��J K

ErrorCodes
��L V
.
��V W
Conflict
��W _
)
��_ `
;
��` a
}
�� 
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$str
�� 4
)
��4 5
;
��5 6
IdentityResult
�� 

roleResult
�� %
=
��& '
await
��( -
this
��. 2
.
��2 3
_userManager
��3 ?
.
��? @
AddToRoleAsync
��@ N
(
��N O
user
��O S
,
��S T
userRole
��U ]
.
��] ^
ToString
��^ f
(
��f g
)
��g h
)
��h i
;
��i j
if
�� 
(
�� 
!
�� 

roleResult
�� 
.
�� 
	Succeeded
�� %
)
��% &
{
�� 
throw
�� 
new
�� 
LevelsUpException
�� +
(
��+ ,
ErrorMessages
��, 9
.
��9 :$
USER_NOT_ADDED_TO_ROLE
��: P
,
��P Q

ErrorCodes
��R \
.
��\ ]
Conflict
��] e
)
��e f
;
��f g
}
�� 
LevelsUpUser
�� 
newUser
��  
=
��! "
await
��# (
this
��) -
.
��- .
_userManager
��. :
.
��: ;
FindByEmailAsync
��; K
(
��K L
registerRequest
��L [
.
��[ \
Email
��\ a
)
��a b
;
��b c
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$str
�� G
)
��G H
;
��H I
UserProfile
�� 
userProfile
�� #
=
��$ %
this
��& *
.
��* +
mapper
��+ 1
.
��1 2
Map
��2 5
<
��5 6
UserProfile
��6 A
>
��A B
(
��B C
registerRequest
��C R
)
��R S
;
��S T
userProfile
�� 
.
�� 
UserId
�� 
=
��  
newUser
��! (
.
��( )
Id
��) +
;
��+ ,
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$str
�� =
)
��= >
;
��> ?
string
�� 
code
�� 
=
�� 
CommonHelpers
�� '
.
��' (!
GenrateRandomNumber
��( ;
(
��; <
)
��< =
;
��= >
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$"
��  I
;Sending the verification code to registered mobile number: 
��  [
{
��[ \
code
��\ `
}
��` a
"
��a b
)
��b c
;
��c d
bool
�� 
IsMessageSend
�� 
=
��  
this
��! %
.
��% &
_twillioService
��& 5
.
��5 6,
SendAccountVerificationMessage
��6 T
(
��T U
userProfile
��U `
.
��` a
GetMobileNumber
��a p
(
��p q
)
��q r
,
��r s
code
��t x
)
��x y
;
��y z
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$"
��  >
0Sending the verification code to email address: 
��  P
{
��P Q
userProfile
��Q \
.
��\ ]
EmailAddress
��] i
}
��i j
"
��j k
)
��k l
;
��l m
this
�� 
.
�� 
_emailService
�� 
.
�� *
SendAccountVerificationEmail
�� ;
(
��; <
userProfile
��< G
.
��G H
EmailAddress
��H T
,
��T U
userProfile
��V a
.
��a b
Name
��b f
,
��f g
code
��h l
)
��l m
;
��m n
if
�� 
(
�� 
IsMessageSend
�� 
)
�� 
{
�� 
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� !
(
��! "
$str
��" O
)
��O P
;
��P Q
userProfile
�� 
.
�� 
VerificationCode
�� ,
=
��- .
code
��/ 3
;
��3 4
IsRegistered
�� 
=
�� 
this
�� #
.
��# $
_userService
��$ 0
.
��0 1
RegisterUser
��1 =
(
��= >
userProfile
��> I
,
��I J
null
��K O
,
��O P
null
��Q U
)
��U V
;
��V W
}
�� 
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$str
�� A
)
��A B
;
��B C
return
�� 
IsRegistered
�� 
;
��  
}
�� 	
public
�� 
async
�� 
Task
�� 
<
�� 
bool
�� 
>
�� 
VerifyAccount
��  -
(
��- ."
VerifyAccountRequest
��. B"
verifyAccountRequest
��C W
)
��W X
{
�� 	
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$str
�� 6
)
��6 7
;
��7 8
LevelsUpUser
�� 
user
�� 
=
�� 
await
��  %
this
��& *
.
��* +
_userManager
��+ 7
.
��7 8
FindByEmailAsync
��8 H
(
��H I"
verifyAccountRequest
��I ]
.
��] ^
Email
��^ c
)
��c d
;
��d e
if
�� 
(
�� 
user
�� 
==
�� 
null
�� 
)
�� 
{
�� 
throw
�� 
new
�� 
LevelsUpException
�� +
(
��+ ,
ErrorMessages
��, 9
.
��9 :,
USER_INVALID_USERNAME_PASSWORD
��: X
,
��X Y

ErrorCodes
��Z d
.
��d e

BadRequest
��e o
)
��o p
;
��p q
}
�� 
bool
�� 

IsVerified
�� 
=
�� 
this
�� "
.
��" #
_userService
��# /
.
��/ 0
VerifyAccount
��0 =
(
��= >"
verifyAccountRequest
��> R
.
��R S
MobileNumber
��S _
,
��_ `"
verifyAccountRequest
��a u
.
��u v
VerificationCode��v �
)��� �
;��� �
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$str
�� B
)
��B C
;
��C D
return
�� 

IsVerified
�� 
;
�� 
}
�� 	
public
�� $
UserProfileInformation
�� %
GetUserProfile
��& 4
(
��4 5
string
��5 ;
userId
��< B
)
��B C
{
�� 	
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$str
�� ;
)
��; <
;
��< =
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$"
��  8
*Getting the user profile with the userId: 
��  J
{
��J K
userId
��K Q
}
��Q R
"
��R S
)
��S T
;
��T U
UserProfile
�� 
userProfile
�� #
=
��$ %
this
��& *
.
��* +!
_userProfileService
��+ >
.
��> ?
GetUserProfile
��? M
(
��M N
$num
��N O
,
��O P
userId
��Q W
:
��W X
userId
��Y _
)
��_ `
;
��` a
if
�� 
(
�� 
userProfile
�� 
==
�� 
null
�� #
)
��# $
{
�� 
throw
�� 
new
�� 
LevelsUpException
�� +
(
��+ ,
ErrorMessages
��, 9
.
��9 :$
USER_PROFILE_NOT_EXIST
��: P
,
��P Q

ErrorCodes
��R \
.
��\ ]
NotFound
��] e
)
��e f
;
��f g
}
�� $
UserProfileInformation
�� "$
userProfileInformation
��# 9
=
��: ;
this
��< @
.
��@ A
mapper
��A G
.
��G H
Map
��H K
<
��K L$
UserProfileInformation
��L b
>
��b c
(
��c d
userProfile
��d o
)
��o p
;
��p q
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$str
�� 9
)
��9 :
;
��: ;
return
�� $
userProfileInformation
�� )
;
��) *
}
�� 	
public
�� 
bool
�� 
UpdateProfile
�� !
(
��! "&
UpdateUserProfileRequest
��" :&
updateUserProfileRequest
��; S
)
��S T
{
�� 	
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$str
�� <
)
��< =
;
��= >
UserProfile
�� 
userProfile
�� #
=
��$ %
this
��& *
.
��* +!
_userProfileService
��+ >
.
��> ?
GetUserProfile
��? M
(
��M N
	profileId
��N W
:
��W X&
updateUserProfileRequest
��Y q
.
��q r
	ProfileId
��r {
)
��{ |
;
��| }
if
�� 
(
�� 
userProfile
�� 
==
�� 
null
�� #
)
��# $
{
�� 
throw
�� 
new
�� 
LevelsUpException
�� +
(
��+ ,
ErrorMessages
��, 9
.
��9 :$
USER_PROFILE_NOT_EXIST
��: P
,
��P Q

ErrorCodes
��R \
.
��\ ]
NotFound
��] e
)
��e f
;
��f g
}
�� 
userProfile
�� 
=
�� 
this
�� 
.
�� 
mapper
�� %
.
��% &
Map
��& )
<
��) *&
UpdateUserProfileRequest
��* B
,
��B C
UserProfile
��D O
>
��O P
(
��P Q&
updateUserProfileRequest
��Q i
,
��i j
userProfile
��k v
)
��v w
;
��w x
bool
�� 
	IsUpdated
�� 
=
�� 
this
�� !
.
��! "!
_userProfileService
��" 5
.
��5 6
UpdateUserProfile
��6 G
(
��G H
userProfile
��H S
)
��S T
;
��T U
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$str
�� :
)
��: ;
;
��; <
return
�� 
	IsUpdated
�� 
;
�� 
}
�� 	
public
�� 
async
�� 
Task
�� 
<
�� 
bool
�� 
>
�� !
ChangePasswordAsync
��  3
(
��3 4#
ChangePasswordRequest
��4 I#
changePasswordRequest
��J _
)
��_ `
{
�� 	
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$"
��  %
Getting user by email: 
��  7
{
��7 8#
changePasswordRequest
��8 M
.
��M N
Email
��N S
}
��S T
"
��T U
)
��U V
;
��V W
LevelsUpUser
�� 
user
�� 
=
�� 
await
��  %
this
��& *
.
��* +
_userManager
��+ 7
.
��7 8
FindByEmailAsync
��8 H
(
��H I#
changePasswordRequest
��I ^
.
��^ _
Email
��_ d
)
��d e
;
��e f
if
�� 
(
�� 
user
�� 
==
�� 
null
�� 
)
�� 
{
�� 
throw
�� 
new
�� 
LevelsUpException
�� +
(
��+ ,
ErrorMessages
��, 9
.
��9 :
USER_NOT_EXIST
��: H
,
��H I

ErrorCodes
��J T
.
��T U
NotFound
��U ]
)
��] ^
;
��^ _
}
�� 
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$"
��  1
#Removing the password of the user: 
��  C
{
��C D
user
��D H
.
��H I
UserName
��I Q
}
��Q R
"
��R S
)
��S T
;
��T U
IdentityResult
�� 
removedResult
�� (
=
��) *
await
��+ 0
this
��1 5
.
��5 6
_userManager
��6 B
.
��B C!
RemovePasswordAsync
��C V
(
��V W
user
��W [
)
��[ \
;
��\ ]
if
�� 
(
�� 
!
�� 
removedResult
�� 
.
�� 
	Succeeded
�� (
)
��( )
{
�� 
throw
�� 
new
�� 
LevelsUpException
�� +
(
��+ ,
removedResult
��, 9
.
��9 :
Errors
��: @
?
��@ A
.
��A B
FirstOrDefault
��B P
(
��P Q
)
��Q R
?
��R S
.
��S T
Description
��T _
)
��_ `
;
��` a
}
�� 
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$"
��  /
!Adding new password of the user: 
��  A
{
��A B
user
��B F
.
��F G
UserName
��G O
}
��O P
"
��P Q
)
��Q R
;
��R S
IdentityResult
�� 
result
�� !
=
��" #
await
��$ )
this
��* .
.
��. /
_userManager
��/ ;
.
��; <
AddPasswordAsync
��< L
(
��L M
user
��M Q
,
��Q R#
changePasswordRequest
��S h
.
��h i
NewPassword
��i t
)
��t u
;
��u v
if
�� 
(
�� 
!
�� 
result
�� 
.
�� 
	Succeeded
�� !
)
��! "
{
�� 
throw
�� 
new
�� 
LevelsUpException
�� +
(
��+ ,
result
��, 2
.
��2 3
Errors
��3 9
?
��9 :
.
��: ;
FirstOrDefault
��; I
(
��I J
)
��J K
?
��K L
.
��L M
Description
��M X
)
��X Y
;
��Y Z
}
�� 
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$str
�� >
)
��> ?
;
��? @
return
�� 
true
�� 
;
�� 
}
�� 	
public
�� 
async
�� 
Task
�� 
<
�� 
TokenResponse
�� '
>
��' (
Login
��) .
(
��. /
LoginRequest
��/ ;
loginRequest
��< H
)
��H I
{
�� 	
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$"
��  .
 Getting user with the username: 
��  @
{
��@ A
loginRequest
��A M
.
��M N
UserName
��N V
}
��V W
"
��W X
)
��X Y
;
��Y Z
LevelsUpUser
�� 
user
�� 
=
�� 
await
��  %
this
��& *
.
��* +
_userManager
��+ 7
.
��7 8
FindByEmailAsync
��8 H
(
��H I
loginRequest
��I U
.
��U V
UserName
��V ^
)
��^ _
;
��_ `
if
�� 
(
�� 
user
�� 
==
�� 
null
�� 
)
�� 
{
�� 
throw
�� 
new
�� 
LevelsUpException
�� +
(
��+ ,
ErrorMessages
��, 9
.
��9 :
USER_NOT_EXIST
��: H
,
��H I

ErrorCodes
��J T
.
��T U
NotFound
��U ]
)
��] ^
;
��^ _
}
�� 
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$"
��  <
.Password sign for the user with the username: 
��  N
{
��N O
loginRequest
��O [
.
��[ \
UserName
��\ d
}
��d e
"
��e f
)
��f g
;
��g h
SignInResult
�� 
result
�� 
=
��  !
await
��" '
this
��( ,
.
��, -
_signInManager
��- ;
.
��; <!
PasswordSignInAsync
��< O
(
��O P
loginRequest
��P \
.
��\ ]
UserName
��] e
,
��e f
loginRequest
��g s
.
��s t
Password
��t |
,
��| }
false��~ �
,��� �
false��� �
)��� �
;��� �
if
�� 
(
�� 
!
�� 
result
�� 
.
�� 
	Succeeded
�� !
)
��! "
{
�� 
throw
�� 
new
�� 
LevelsUpException
�� +
(
��+ ,
ErrorMessages
��, 9
.
��9 :,
USER_INVALID_USERNAME_PASSWORD
��: X
,
��X Y

ErrorCodes
��Z d
.
��d e

BadRequest
��e o
)
��o p
;
��p q
}
�� 
else
�� 
if
�� 
(
�� 
result
�� 
.
�� 
IsLockedOut
�� '
)
��' (
{
�� 
throw
�� 
new
�� 
LevelsUpException
�� +
(
��+ ,
ErrorMessages
��, 9
.
��9 :
USER_IS_DISABLED
��: J
,
��J K

ErrorCodes
��L V
.
��V W!
UnprocessableEntity
��W j
)
��j k
;
��k l
}
�� 
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$str
�� :
)
��: ;
;
��; <
IList
�� 
<
�� 
string
�� 
>
�� 
roles
�� 
=
��  !
await
��" '
this
��( ,
.
��, -
_userManager
��- 9
.
��9 :
GetRolesAsync
��: G
(
��G H
user
��H L
)
��L M
;
��M N
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$"
��  :
,Generating token of user with the username: 
��  L
{
��L M
user
��M Q
.
��Q R
UserName
��R Z
}
��Z [
 and role: 
��[ f
{
��f g
roles
��g l
.
��l m
FirstOrDefault
��m {
(
��{ |
)
��| }
}
��} ~
"
��~ 
)�� �
;��� �
TokenResponse
�� 
tokenResponse
�� '
=
��( )
this
��* .
.
��. /#
_GenerateJSONWebToken
��/ D
(
��D E
user
��E I
,
��I J
roles
��K P
)
��P Q
;
��Q R
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$str
�� 4
)
��4 5
;
��5 6
return
�� 
tokenResponse
��  
;
��  !
}
�� 	
public
�� 
async
�� 
Task
�� 
<
�� 
TokenResponse
�� '
>
��' ("
GenerateRefreshToken
��) =
(
��= >!
RefreshTokenRequest
��> Q!
refreshTokenRequest
��R e
)
��e f
{
�� 	
SecurityToken
�� 
securityToken
�� '
;
��' (
ClaimsPrincipal
�� 
	principle
�� %
=
��& '
this
��( ,
.
��, -&
_jwtSecurityTokenHandler
��- E
.
��E F
ValidateToken
��F S
(
��S T!
refreshTokenRequest
��T g
.
��g h!
AuthenticationToken
��h {
,
��{ |.
TokenValidationParameterHelpers��} �
.��� �3
#GetExpiredTokenValidationParameters��� �
(��� �
)��� �
,��� �
out��� �
securityToken��� �
)��� �
;��� �
JwtSecurityToken
�� 
jwtToken
�� %
=
��& '
securityToken
��( 5
as
��6 8
JwtSecurityToken
��9 I
;
��I J
if
�� 
(
�� 
jwtToken
�� 
==
�� 
null
��  
||
��! #
!
��$ %
jwtToken
��% -
.
��- .
Header
��. 4
.
��4 5
Alg
��5 8
.
��8 9
Equals
��9 ?
(
��? @ 
SecurityAlgorithms
��@ R
.
��R S

HmacSha256
��S ]
)
��] ^
)
��^ _
{
�� 
throw
�� 
new
�� 
LevelsUpException
�� +
(
��+ ,
ErrorMessages
��, 9
.
��9 : 
UNAUTHORIZED_ERROR
��: L
,
��L M

ErrorCodes
��N X
.
��X Y
Unauthorized
��Y e
)
��e f
;
��f g
}
�� 
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$"
��  2
$Getting the userId from the jwtToken
��  D
"
��D E
)
��E F
;
��F G
string
�� 
userId
�� 
=
�� 
jwtToken
�� $
.
��$ %
Claims
��% +
.
��+ ,
GetClaimValue
��, 9
(
��9 :
EnumHelpers
��: E
.
��E F
GetDescription
��F T
(
��T U"
MiddlewareClaimTypes
��U i
.
��i j
UserId
��j p
)
��p q
)
��q r
;
��r s
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$"
��  K
=Getting the refresh token from the database with the userId: 
��  ]
{
��] ^
userId
��^ d
}
��d e
"
��e f
)
��f g
;
��g h
RefreshToken
�� 
refreshToken
�� %
=
��& '
this
��( ,
.
��, -
_userService
��- 9
.
��9 :
GetRefreshToken
��: I
(
��I J
userId
��J P
,
��P Q!
refreshTokenRequest
��R e
.
��e f
RefreshToken
��f r
)
��r s
;
��s t
if
�� 
(
�� 
refreshToken
�� 
==
�� 
null
��  $
||
��% '
refreshToken
��( 4
.
��4 5
IsUsed
��5 ;
)
��; <
{
�� 
throw
�� 
new
�� 
LevelsUpException
�� +
(
��+ ,
ErrorMessages
��, 9
.
��9 :
USER_NOT_EXIST
��: H
,
��H I

ErrorCodes
��J T
.
��T U
Unauthorized
��U a
)
��a b
;
��b c
}
�� 
string
�� 
username
�� 
=
�� 
	principle
�� '
.
��' (
Identity
��( 0
.
��0 1
Name
��1 5
;
��5 6
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$"
��  .
 Getting user with the username: 
��  @
{
��@ A
username
��A I
}
��I J
"
��J K
)
��K L
;
��L M
LevelsUpUser
�� 
user
�� 
=
�� 
await
��  %
this
��& *
.
��* +
_userManager
��+ 7
.
��7 8
FindByEmailAsync
��8 H
(
��H I
username
��I Q
)
��Q R
;
��R S
if
�� 
(
�� 
user
�� 
==
�� 
null
�� 
)
�� 
{
�� 
throw
�� 
new
�� 
LevelsUpException
�� +
(
��+ ,
ErrorMessages
��, 9
.
��9 :
USER_NOT_EXIST
��: H
,
��H I

ErrorCodes
��J T
.
��T U
NotFound
��U ]
)
��] ^
;
��^ _
}
�� 
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$str
�� :
)
��: ;
;
��; <
IList
�� 
<
�� 
string
�� 
>
�� 
roles
�� 
=
��  !
await
��" '
this
��( ,
.
��, -
_userManager
��- 9
.
��9 :
GetRolesAsync
��: G
(
��G H
user
��H L
)
��L M
;
��M N
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$"
��  :
,Generating token of user with the username: 
��  L
{
��L M
user
��M Q
.
��Q R
UserName
��R Z
}
��Z [
 and role: 
��[ f
{
��f g
roles
��g l
.
��l m
FirstOrDefault
��m {
(
��{ |
)
��| }
}
��} ~
"
��~ 
)�� �
;��� �
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$"
��  
"
��  !
)
��! "
;
��" #
refreshToken
�� 
.
�� 
IsUsed
�� 
=
��  !
true
��" &
;
��& '
this
�� 
.
�� 
_userService
�� 
.
��  
UpdateRefreshToken
�� 0
(
��0 1
refreshToken
��1 =
)
��= >
;
��> ?
TokenResponse
�� 
tokenResponse
�� '
=
��( )
this
��* .
.
��. /#
_GenerateJSONWebToken
��/ D
(
��D E
user
��E I
,
��I J
roles
��K P
)
��P Q
;
��Q R
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$str
�� ;
)
��; <
;
��< =
return
�� 
tokenResponse
��  
;
��  !
}
�� 	
public
�� 
async
�� 
Task
�� 
<
�� 
bool
�� 
>
�� 
Logout
��  &
(
��& '
)
��' (
{
�� 	
string
�� 
userId
�� 
=
�� 
this
��  
.
��  !!
httpContextAccessor
��! 4
.
��4 5
GetCurrentUserId
��5 E
(
��E F
)
��F G
;
��G H
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$"
��  "
Getting user by id: 
��  4
{
��4 5
userId
��5 ;
}
��; <
"
��< =
)
��= >
;
��> ?
LevelsUpUser
�� 
user
�� 
=
�� 
await
��  %
this
��& *
.
��* +
_userManager
��+ 7
.
��7 8
FindByIdAsync
��8 E
(
��E F
userId
��F L
)
��L M
;
��M N
if
�� 
(
�� 
user
�� 
!=
�� 
null
�� 
)
�� 
{
�� 
await
�� 
this
�� 
.
�� 
_signInManager
�� )
.
��) *
SignOutAsync
��* 6
(
��6 7
)
��7 8
;
��8 9
}
�� 
this
�� 
.
�� 
logger
�� 
.
�� 
Debug
�� 
(
�� 
$str
�� 5
)
��5 6
;
��6 7
return
�� 
true
�� 
;
�� 
}
�� 	
private
�� 
TokenResponse
�� #
_GenerateJSONWebToken
�� 3
(
��3 4
LevelsUpUser
��4 @
applicationUser
��A P
,
��P Q
IList
��R W
<
��W X
string
��X ^
>
��^ _
roles
��` e
)
��e f
{
�� 	
List
�� 
<
�� 
Claim
�� 
>
�� 
claims
�� 
=
��  
new
��! $
List
��% )
<
��) *
Claim
��* /
>
��/ 0
(
��0 1
)
��1 2
{
�� 
new
�� 
Claim
�� 
(
�� 

ClaimTypes
�� $
.
��$ %
Name
��% )
,
��) *
applicationUser
��+ :
.
��: ;
UserName
��; C
)
��C D
,
��D E
new
�� 
Claim
�� 
(
�� 

ClaimTypes
�� $
.
��$ %
Email
��% *
,
��* +
applicationUser
��, ;
.
��; <
Email
��< A
)
��A B
,
��B C
new
�� 
Claim
�� 
(
�� 

ClaimTypes
�� $
.
��$ %
Role
��% )
,
��) *
roles
��+ 0
.
��0 1
FirstOrDefault
��1 ?
(
��? @
)
��@ A
)
��A B
,
��B C
new
�� 
Claim
�� 
(
�� 

ClaimTypes
�� $
.
��$ %
NameIdentifier
��% 3
,
��4 5
applicationUser
��6 E
.
��E F
Id
��F H
)
��H I
}
�� 
;
�� 

Dictionary
�� 
<
�� 
string
�� 
,
�� 
object
�� %
>
��% &
claimsDictionary
��' 7
=
��8 9
claims
��: @
.
��@ A
ToDictionary
��A M
(
��M N
x
��N O
=>
��P R
x
��S T
.
��T U
Type
��U Y
,
��Y Z
x
��[ \
=>
��] _
(
��` a
object
��a g
)
��g h
x
��h i
.
��i j
Value
��j o
)
��o p
;
��p q%
SecurityTokenDescriptor
�� #
tokenDescriptor
��$ 3
=
��4 5
new
��6 9%
SecurityTokenDescriptor
��: Q
(
��Q R
)
��R S
{
�� 
Subject
�� 
=
�� 
new
�� 
ClaimsIdentity
�� ,
(
��, -
claims
��- 3
,
��3 4
	Constants
��5 >
.
��> ?
	TokenType
��? H
)
��H I
,
��I J
Claims
�� 
=
�� 
claimsDictionary
�� )
,
��) *
Expires
�� 
=
�� 
DateTime
�� "
.
��" #
UtcNow
��# )
.
��) *

AddMinutes
��* 4
(
��4 5
this
��5 9
.
��9 :"
_jsonWebTokenSetting
��: N
.
��N O

ExpireTime
��O Y
)
��Y Z
,
��Z [ 
SigningCredentials
�� "
=
��# $
new
��% ( 
SigningCredentials
��) ;
(
��; <
this
��< @
.
��@ A"
_jsonWebTokenSetting
��A U
.
��U V
Key
��V Y
.
��Y Z+
ConvertToSymmetricSecurityKey
��Z w
(
��w x
)
��x y
,
��y z!
SecurityAlgorithms��{ �
.��� �

HmacSha256��� �
)��� �
,��� �
IssuedAt
�� 
=
�� 
DateTime
�� #
.
��# $
UtcNow
��$ *
,
��* +
Issuer
�� 
=
�� 
this
�� 
.
�� "
_jsonWebTokenSetting
�� 2
.
��2 3
Issuer
��3 9
,
��9 :
Audience
�� 
=
�� 
this
�� 
.
��  "
_jsonWebTokenSetting
��  4
.
��4 5
Issuer
��5 ;
,
��; <
}
�� 
;
�� 
SecurityToken
�� 
jwtToken
�� "
=
��# $
this
��% )
.
��) *&
_jwtSecurityTokenHandler
��* B
.
��B C
CreateToken
��C N
(
��N O
tokenDescriptor
��O ^
)
��^ _
;
��_ `
string
�� 
token
�� 
=
�� 
this
�� 
.
��  &
_jwtSecurityTokenHandler
��  8
.
��8 9

WriteToken
��9 C
(
��C D
jwtToken
��D L
)
��L M
;
��M N
string
�� 
refreshToken
�� 
=
��  !
this
��" &
.
��& '
_GetRefreshToken
��' 7
(
��7 8
applicationUser
��8 G
.
��G H
Id
��H J
)
��J K
;
��K L
TokenResponse
�� 
tokenResponse
�� '
=
��( )
new
��* -
TokenResponse
��. ;
(
��; <
)
��< =
{
�� 

auth_token
�� 
=
�� 
token
�� "
,
��" #
refresh_token
�� 
=
�� 
refreshToken
��  ,
,
��, -
expiration_time
�� 
=
��  !
jwtToken
��" *
.
��* +
ValidTo
��+ 2
.
��2 3
ToString
��3 ;
(
��; <
	Constants
��< E
.
��E F"
MobileDateTimeFormat
��F Z
)
��Z [
,
��[ \

issue_time
�� 
=
�� 
jwtToken
�� %
.
��% &
	ValidFrom
��& /
.
��/ 0
ToString
��0 8
(
��8 9
	Constants
��9 B
.
��B C"
MobileDateTimeFormat
��C W
)
��W X
,
��X Y
role
�� 
=
�� 
roles
�� 
.
�� 
FirstOrDefault
�� +
(
��+ ,
)
��, -
}
�� 
;
�� 
return
�� 
tokenResponse
��  
;
��  !
}
�� 	
private
�� 
string
�� 
_GetRefreshToken
�� '
(
��' (
string
��( .
userId
��/ 5
)
��5 6
{
�� 	
string
�� 
refreshToken
�� 
=
��  !
string
��" (
.
��( )
Empty
��) .
;
��. /
byte
�� 
[
�� 
]
�� 
randomNumber
�� 
=
��  !
new
��" %
byte
��& *
[
��* +
$num
��+ -
]
��- .
;
��. /
using
�� 
(
�� #
RandomNumberGenerator
�� (#
randomNumberGenerator
��) >
=
��? @#
RandomNumberGenerator
��A V
.
��V W
Create
��W ]
(
��] ^
)
��^ _
)
��_ `
{
�� #
randomNumberGenerator
�� %
.
��% &
GetBytes
��& .
(
��. /
randomNumber
��/ ;
)
��; <
;
��< =
refreshToken
�� 
=
�� 
Convert
�� &
.
��& '
ToBase64String
��' 5
(
��5 6
randomNumber
��6 B
)
��B C
;
��C D
}
�� 
RefreshToken
�� 
refreshTokenObj
�� (
=
��) *
new
��+ .
RefreshToken
��/ ;
(
��; <
)
��< =
{
�� 
UserId
�� 
=
�� 
userId
�� 
,
��  
Token
�� 
=
�� 
refreshToken
�� $
,
��$ %
IsUsed
�� 
=
�� 
false
�� 
,
�� 
	IsRevoked
�� 
=
�� 
false
�� !
,
��! "
	CreatedOn
�� 
=
�� 
DateTime
�� $
.
��$ %
UtcNow
��% +
}
�� 
;
�� 
this
�� 
.
�� 
_userService
�� 
.
�� 
AddRefreshToken
�� -
(
��- .
refreshTokenObj
��. =
)
��= >
;
��> ?
return
�� 
refreshToken
�� 
;
��  
}
�� 	
}
�� 
}�� �
PD:\DotNetCore\DotNetCoreAPI\BusinessOperations\Implementations\BOUserCategory.cs
	namespace

 	
BusinessOperations


 
.

 
Implementations

 ,
{ 
public 

class 
BOUserCategory 
:  !!
BaseBusinessOperation" 7
,7 8
IBOUserCategory9 H
{ 
private 
readonly  
IUserCategoryService - 
_userCategoryService. B
;B C
public 
BOUserCategory 
(  
IUserCategoryService 2
userCategoryService3 F
)F G
:H I
baseJ N
(N O
)O P
{ 	
this 
.  
_userCategoryService %
=& '
userCategoryService( ;
;; <
} 	
public'' 
List'' 
<'' #
UserCategoryInformation'' +
>''+ ,
Get''- 0
(''0 1
string''1 7
userId''8 >
)''> ?
{(( 	
this)) 
.)) 
logger)) 
.)) 
Debug)) 
()) 
$str)) >
)))> ?
;))? @
this++ 
.++ 
logger++ 
.++ 
Debug++ 
(++ 
$"++  C
7Getting the user category information with the userId: ++  W
{++W X
userId++X ^
}++^ _
"++_ `
)++` a
;++a b
List-- 
<-- 
UserCategory-- 
>-- 
userCategories-- -
=--. /
this--0 4
.--4 5 
_userCategoryService--5 I
.--I J
Get--J M
(--M N
userId--N T
)--T U
;--U V
this.. 
... 
logger.. 
... 
Debug.. 
(.. 
$"..  $
User category count is: ..  8
{..8 9
userCategories..9 G
...G H
Count..H M
}..M N
"..N O
)..O P
;..P Q
if// 
(// 
userCategories// 
.// 
IsNotAny// '
(//' (
)//( )
)//) *
{00 
throw11 
new11 
LevelsUpException11 +
(11+ ,
ErrorMessages11, 9
.119 :%
USER_CATEGORIES_NOT_EXIST11: S
,11S T

ErrorCodes11U _
.11_ `
NotFound11` h
)11h i
;11i j
}22 
List44 
<44 #
UserCategoryInformation44 (
>44( )#
userCategoryInformation44* A
=44B C
this44D H
.44H I
mapper44I O
.44O P
Map44P S
<44S T
List44T X
<44X Y#
UserCategoryInformation44Y p
>44p q
>44q r
(44r s
userCategories	44s �
)
44� �
;
44� �
this66 
.66 
logger66 
.66 
Debug66 
(66 
$str66 <
)66< =
;66= >
return88 #
userCategoryInformation88 *
;88* +
}99 	
}:: 
};; �
SD:\DotNetCore\DotNetCoreAPI\BusinessOperations\Implementations\BOUserSubCategory.cs
	namespace 	
BusinessOperations
 
. 
Implementations ,
{		 
public 

class 
BOUserSubCategory "
:# $!
BaseBusinessOperation% :
,: ;
IBOUserSubCategory< N
{ 
private 
readonly #
IUserSubCategoryService 0#
_userSubCategoryService1 H
;H I
public 
BOUserSubCategory  
(  !#
IUserSubCategoryService! 8"
userSubCategoryService9 O
)O P
:Q R
baseS W
(W X
)X Y
{ 	
this 
. #
_userSubCategoryService (
=) *"
userSubCategoryService+ A
;A B
} 	
public%% 
List%% 
<%% &
UserSubCategoryInformation%% .
>%%. /
Get%%0 3
(%%3 4
string%%4 :
userId%%; A
)%%A B
{&& 	
if'' 
('' 
string'' 
.'' 
IsNullOrEmpty'' $
(''$ %
userId''% +
)''+ ,
)'', -
{(( 
this)) 
.)) 
logger)) 
.)) 
Debug)) !
())! "
$str))" 6
)))6 7
;))7 8
userId** 
=** 
this** 
.** 
httpContextAccessor** 1
.**1 2
GetCurrentUserId**2 B
(**B C
)**C D
;**D E
}++ 
List-- 
<-- 
UserSubCategory--  
>--  !
subCategories--" /
=--0 1
this--2 6
.--6 7#
_userSubCategoryService--7 N
.--N O
Get--O R
(--R S
userId--S Y
)--Y Z
;--Z [
return// 
this// 
.// 
mapper// 
.// 
Map// "
<//" #
List//# '
<//' (&
UserSubCategoryInformation//( B
>//B C
>//C D
(//D E
subCategories//E R
)//R S
;//S T
}00 	
}11 
}22 �
KD:\DotNetCore\DotNetCoreAPI\BusinessOperations\Interfaces\IBOSubCategory.cs
	namespace 	
BusinessOperations
 
. 

Interfaces '
{ 
public		 

	interface		 
IBOSubCategory		 #
:		$ %
IBusinessOperation		& 8
{

 ,
 UserSubCategoryDetailInformation (
Get) ,
(, -
int- 0
id1 3
)3 4
;4 5
} 
} �
DD:\DotNetCore\DotNetCoreAPI\BusinessOperations\Interfaces\IBOUser.cs
	namespace 	
BusinessOperations
 
. 

Interfaces '
{ 
public 

	interface 
IBOUser 
: 
IBusinessOperation 1
{ 
Task 
< 
bool 
> 
RegisterUserAsync $
($ %
RegisterRequest% 4
registerRequest5 D
,D E
	UserRolesF O
userRoleP X
)X Y
;Y Z
Task 
< 
bool 
> 
VerifyAccount  
(  ! 
VerifyAccountRequest! 5 
verifyAccountRequest6 J
)J K
;K L"
UserProfileInformation(( 
GetUserProfile(( -
(((- .
string((. 4
userId((5 ;
)((; <
;((< =
bool11 
UpdateProfile11 
(11 $
UpdateUserProfileRequest11 3$
updateUserProfileRequest114 L
)11L M
;11M N
Task:: 
<:: 
bool:: 
>:: 
ChangePasswordAsync:: &
(::& '!
ChangePasswordRequest::' <!
changePasswordRequest::= R
)::R S
;::S T
TaskCC 
<CC 
TokenResponseCC 
>CC 
LoginCC !
(CC! "
LoginRequestCC" .
loginRequestCC/ ;
)CC; <
;CC< =
TaskLL 
<LL 
TokenResponseLL 
>LL  
GenerateRefreshTokenLL 0
(LL0 1
RefreshTokenRequestLL1 D
refreshTokenRequestLLE X
)LLX Y
;LLY Z
TaskTT 
<TT 
boolTT 
>TT 
LogoutTT 
(TT 
)TT 
;TT 
}UU 
}VV �
LD:\DotNetCore\DotNetCoreAPI\BusinessOperations\Interfaces\IBOUserCategory.cs
	namespace 	
BusinessOperations
 
. 

Interfaces '
{ 
public

 

	interface

 
IBOUserCategory

 $
:

% &
IBusinessOperation

' 9
{ 
List 
< #
UserCategoryInformation $
>$ %
Get& )
() *
string* 0
userId1 7
)7 8
;8 9
} 
} �
OD:\DotNetCore\DotNetCoreAPI\BusinessOperations\Interfaces\IBOUserSubCategory.cs
	namespace 	
BusinessOperations
 
. 

Interfaces '
{ 
public

 

	interface

 
IBOUserSubCategory

 '
:

( )
IBusinessOperation

* <
{ 
List 
< &
UserSubCategoryInformation '
>' (
Get) ,
(, -
string- 3
userId4 :
): ;
;; <
} 
} �
OD:\DotNetCore\DotNetCoreAPI\BusinessOperations\Interfaces\IBusinessOperation.cs
	namespace 	
BusinessOperations
 
. 

Interfaces '
{ 
public 

	interface 
IBusinessOperation '
{ 
} 
}		 �
JD:\DotNetCore\DotNetCoreAPI\BusinessOperations\PostSharp\ProfilerAspect.cs
	namespace		 	
BusinessOperations		
 
.		 
	PostSharp		 &
{

 
[ 
Serializable 
] 
[ 
AttributeUsage 
( 
AttributeTargets $
.$ %
Assembly% -
|. /
AttributeTargets0 @
.@ A
MethodA G
)G H
]H I
public 

class 
ProfilerAspect 
:  !
OnExceptionAspect" 3
{ 
public 
override 
void 
OnException (
(( )
MethodExecutionArgs) <
args= A
)A B
{ 	
IServiceProvider 
serviceProvider ,
=- .
ServiceHelpers/ =
.= >
GetServiceProvider> P
(P Q
)Q R
;R S
ILogger 
logger 
= 
serviceProvider ,
., -
GetRequiredService- ?
<? @
ILogger@ G
>G H
(H I
)I J
;J K
Type 
type 
= 
args 
. 
	Exception &
.& '
GetType' .
(. /
)/ 0
;0 1
logger 
. 
Debug 
( 
args 
. 
	Exception '
.' (
Message( /
)/ 0
;0 1
if 
( 
type 
== 
typeof 
( 
LevelsUpException 0
)0 1
)1 2
{   
throw!! 
args!! 
.!! 
	Exception!! $
;!!$ %
}"" 
else## 
{$$ 
throw%% 
new%% 
LevelsUpException%% +
(%%+ ,
ErrorMessages%%, 9
.%%9 :!
INTERNAL_SERVER_ERROR%%: O
,%%O P

ErrorCodes%%Q [
.%%[ \
InternalServerError%%\ o
)%%o p
;%%p q
}&& 
}'' 	
}(( 
})) �
ID:\DotNetCore\DotNetCoreAPI\BusinessOperations\Properties\AssemblyInfo.cs
[		 
assembly		 	
:			 

AssemblyTitle		 
(		 
$str		 -
)		- .
]		. /
[

 
assembly

 	
:

	 

AssemblyDescription

 
(

 
$str

 !
)

! "
]

" #
[ 
assembly 	
:	 
!
AssemblyConfiguration  
(  !
$str! #
)# $
]$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str 
) 
] 
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str /
)/ 0
]0 1
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
[$$ 
assembly$$ 	
:$$	 

AssemblyVersion$$ 
($$ 
$str$$ $
)$$$ %
]$$% &
[%% 
assembly%% 	
:%%	 

AssemblyFileVersion%% 
(%% 
$str%% (
)%%( )
]%%) *
[&& 
assembly&& 	
:&&	 

ProfilerAspect&& 
(&&  
AttributeTargetTypes&& .
=&&/ 0
$str&&1 G
)&&G H
]&&H I