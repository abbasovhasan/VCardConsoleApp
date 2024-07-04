# Dynamic vCard

```Randomuser.me``` saytından random istifadəçi məlumatları çəkərək dinamik VCard ərsəyə gətirir.

#### JSON Deserialize
İlk öncə, məlumatları əldə etmək və JSON formatına gətirmək üçün ```  HttpClient ``` istifadə edilir. Daha sonra isə gətirilən məlumatları əvvəlcədən yaratdığımız ``` vcard ``` sinifinə deserialize edilməsi üçün isə [Newtonsoft](https://www.newtonsoft.com/json) package-dən istifadə edirik.

#### VCardSaver
Sonda isə məlumatlar ``` .vcf ``` formatinda save olunur. Əvvəlcə faylı save etmək üçün lazımi faylın varlığı yoxlanır. Əgər yoxdursa, yenisi yaradılır və məlumatlar həmin faylın içərisinə ``` .vcf ``` formatında saxlanılır. Əgər mövcud fayl varsa, məlumatlar həmin faylın içərisində saxlanılır.