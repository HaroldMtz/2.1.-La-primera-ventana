# Actividad 2.3 – Programación de botones (Unity)

## ¿Qué hace?
- **Arrastrar** iconos (UI) con el mouse.
- **Cambiar fuente, tamaño y color** del título (TextMeshPro).
- **Navegar** entre páginas con botones (Prev / Next).

## Archivos clave
- `Assets/Scripts/DragUIElement.cs` → Arrastrar iconos UI.
- `Assets/Scripts/FontControllerTMP.cs` → Fuente, tamaño y color del título.
- `Assets/Scripts/PageController.cs` → Navegación entre paneles (Page1/Page2).

## Escena (muy básico)
Canvas  
└─ TopBar → **Title (TMP_Text)**  
└─ Content → **Page1**, **Page2**  
└─ BottomBar  
   ├─ MainButtons → (tus 3 botones)  
   └─ FontButtons → **BtnFontPlus**, **BtnFontMinus**, **BtnFontReset**, **BtnFontToggle**  
└─ Controller → (tiene `FontControllerTMP` y `PageController`)

> Canvas Scaler: *Scale With Screen Size*, 1920×1080, Match 0.5  
> TopBar: Top-Stretch (Height ≈ 110) · BottomBar: Bottom-Stretch (Height ≈ 96)  
> Content: Full-Stretch (Top=110, Bottom=96)

## Cómo probar (3 pasos)
1) **Arrastre**: en `Page1/IconsGrid` cada icono tiene `DragUIElement` → arrástralo.  
2) **Fuentes** (en FontButtons):  
   - **+ / −** → cambia tamaño del **Title**  
   - **Reset** → restaura tamaño y color  
   - **Fuente** → cambia **tipografía y color**  
3) **Navegación**: **Prev / Next** alternan entre **Page1** y **Page2**.

## Conexiones de botones (OnClick)
En **Controller**:
- `FontControllerTMP` → targets: `TopBar/Title`; fonts: **2 o más** TMP Font Assets.
- `PageController` → pages: `[Page1, Page2]`.

En **BottomBar/FontButtons**:
- `BtnFontPlus`  → `FontControllerTMP.IncreaseSize()`
- `BtnFontMinus` → `FontControllerTMP.DecreaseSize()`
- `BtnFontReset` → `FontControllerTMP.ResetSize()` **y** `FontControllerTMP.ResetColor()`
- `BtnFontToggle`→ `FontControllerTMP.NextFont()` **y** `FontControllerTMP.NextColor()`

En **MainButtons** (o donde tengas Prev/Next):
- `Prev` → `PageController.Prev()`
- `Next` → `PageController.Next()`

## Entrega
1) Play: verifica **arrastre**, **fuentes**, **navegación**.  
2) Sube al repo y manda el link.

### Commit sugerido
feat: 2.3 (drag UI, control de fuentes TMP y navegación)
