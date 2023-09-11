- 3 Assignments (10%)
- 2 Progress Tests (10%)
- PE - tập trung
- TE - 
- Group project (25%) 
    - Tách rời frontend và backend
    - Không làm băng postman hoặc swagger
    - Sử dung công nghệ Data Centric, chọn 2 option, 1 cũng được nhưng chỉ được 7 - 8 điểm
        - API + OData - Reconmend by teacher
        - CoreWCF (Mutiple protocol)
        - GoogleRPC - Reconmend by teacher
    - Có authentication - nuget JWT
    - API viết theo 3 layer (Backend)
    - Client app kết nối với Api (Frondend) 
        - ReactJS
        - Angular
        - VueJS 
        - Desktop WPF, RazorPages, MVC


1. Resources
- Group topic: https://feedu-my.sharepoint.com/:x:/g/personal/huongntc2_fe_edu_vn/Ea0bihGWGEZMgpQQeN_JYE4B84esc0WMNv4cxw8_T9CSDQ?e=nqWZHI                                                                                                
Link to related resources: https://drive.google.com/drive/folders/1rX59Pl0Mtr61M2vCRPfcJK7D2FNvcVnt?usp=sharing

2. Notice things
    - Postman
    - Web server - ASP.NET Core
        - Local Server - Kestrel
        - Proxy Server - IIS, Apache, Nginx
    - Web Client (Browser supports JavaScript) / Postman (None-JavaScript Client)
        - Http Resquest message 4 thành phần: Method, URL, Headers (Collection bao gồm nhiều thứ), Body
        - Http Response message 3 thành phần: Status code, Headers, Body

- ASP.NET Core web API (MVC without V --> Data Centric)
    Model? String/Numver/Object/Collection/Null

- Local Server (Kestrel) / Proxy Server IIS, Apache, Nginx, 
    Request --> Proxy server --> Local Server --> (Binding, Validation) --> Xử lý --> Response

- Server Container (IoC - Inversion of control) - Dependency Injection - ServiceCollection
    .AddControllerWithVier()
    .AddSession()
    .............
- Http requests pipeline - các cái Middleware
    .UseStaticFile()
    .UseSession()
    .UseAuthentication()
    ....................

- Controller -> Class
    [ApiController ] // to make this class to controller
    [Route("api/[controller ]") ] // Điều phối 
    class XXXController : ControllerBase { // http://localhost:5000/api/XXXName
        // Action Method
        [HttpVerbs: HttpGet, HttpPost, HttpPost,...] // Anottation attributes for swagger 
        KiểuReturn MethodName(DanhSáchParameter)
    }
- ControllerBase vs Controller:
    ControllerBase:

- Action Method -> Method (HTTP Verbs: POST/PUT/DELETE/GET/...)

Client                               ASP.NET Core WebAPI (Local Kestrel)
- Swagger       | --------------> |
- PostMan       | --------------> |
- WPF           | --------------> |
- MobileApp     | --------------> |
- RazorPages    | --------------> |
                    Middleware


- Client App 
    .GetAsync()
    .PostAsync()
    .PutAsync()
    .DeleteAsync()