﻿## v3.7.6
### Demo site and documentation 
- Improve API documentation by showing preview of default icon ([#2284](https://github.com/microsoft/fluentui-blazor/pull/2284))

### Components
- [Autocomplete] Fix ReadOnly and Disable properties ([#2291](https://github.com/microsoft/fluentui-blazor/pull/2291))


## v3.7.5

### Demo site and documentation 
- Improve API documentation by showing default icon and string values ([#2269](https://github.com/microsoft/fluentui-blazor/pull/2269))

### Components
- [AutoComplete] Allow focusable Badge dismiss buttons (accessibility) ([#2272](https://github.com/microsoft/fluentui-blazor/pull/2272))

### Icons
- Introduction of a new 'Light' variant of icons. For now a set of 153 icons in size 32 has been added.
- Update to Fluent UI System Icons 1.1.245
    
    **What's new (Name / Size(s) / Variant(s))**
    - Arrow Collapse All / 16 / Filled & Regular
    - Arrow Expand All / 16, 20, 24 / Filled & Regular
    - Chat Arrow Back Down / 16, 20, 24, 28, 32, 48 / Filled & Regular
    - Desktop Arrow Down / 32 / Filled & Regular
    - Edit Line Horizontal 3 / 20, 24 / Filled & Regular
    - Gift Open / 32 / Filled & Regular
    - Prompt / 16, 20, 24, 28, 32, 48 / Filled & Regular
    - Search Sparkle / 16, 20, 24, 28, 32, 48 / Filled & Regular
    - Slide Text Call / 16, 20, 24, 28, 48 / Filled & Regular
    - Slide Text Cursor / 20, 24 / Filled & Regular    
    - Vehicle Motorcycle / 16, 20, 24, 28, 32, 48 / Filled & Regular

     **What's updated (Name / Size(s) / Variant(s))**
    - Arrow Collapse All / 20, 24 / Filled & Regular

## V3.7.4

### Icons
- [Icons] Add new `Light` value to `IconVariant` enum.
 
## v3.7.3

### Components
- [AutoComplete] Fix AutoComplet no longer working when the user tries to select an item using the mouse.

## v3.7.2

### Components

- [Card] Support AreaRestricted for MinimalStyle also ([#2170](https://github.com/microsoft/fluentui-blazor/pull/2170))
- [ComboBox] bind-SelectedOption is null when using bind-SelectedOption:after  ([#2102](https://github.com/microsoft/fluentui-blazor/pull/2102))
- [DataGrid] Allow programmatic sorting of columns by name or index ([#2156](https://github.com/microsoft/fluentui-blazor/pull/2156))
- [DataGrid] Check datagrid's rowelements when correcting column options ([#2117](https://github.com/microsoft/fluentui-blazor/pull/2117))
- [DesignToken] Add WithDefault overload ([#2159](https://github.com/microsoft/fluentui-blazor/pull/2159))
- [Dialog] Use FluentTooltip for close button (a11y)
- [FluentAutocomplete] Add SelectValueOnTab attribute ([#2110](https://github.com/microsoft/fluentui-blazor/pull/2110))
- [FluentKeyCode] Add KeyUp event ([#2122](https://github.com/microsoft/fluentui-blazor/pull/2122))
- [Header] Add Id to the container header tag ([#2125](https://github.com/microsoft/fluentui-blazor/pull/2125))
- [Inputs] Adds FieldIdentifier parameter ([#2114](https://github.com/microsoft/fluentui-blazor/pull/2114))
- [Layout] Add Id to the container div ([#2123](https://github.com/microsoft/fluentui-blazor/pull/2123))
- [Layout] Add Orientation support ([#2096](https://github.com/microsoft/fluentui-blazor/pull/2096))
- [MarkdownSection] Optimize to minimize number of calls to OnContentConverted ([#2092](https://github.com/microsoft/fluentui-blazor/pull/2092))
- [NavMenu] Fix double click needed for expanding/collapsing child elements when prerendering is turned off ([#2133](https://github.com/microsoft/fluentui-blazor/pull/2133))
- [NavMenu] Fix FluentNavLink to support CustomColor ([#2116](https://github.com/microsoft/fluentui-blazor/pull/2116))
- [Progress] Fix height in Indeterminate mode by using InvariantCulture ([#2120](https://github.com/microsoft/fluentui-blazor/pull/2120))

### Icons
- Update to Fluent UI System Icons 1.1.242

	**What's new (Name / Size(s) / Variant(s))**
	- Breakout Room / 32 / Filled & Regular
	- Card UI Portrait Flip / 16, 20, 24 / Filled & Regular
	- Cursor / 28, 32 / Filled & Regular
	- Layout Row Two / 28, 48 / Filled & Regular
	- Notepad Sparkle / 16, 20, 24, 28, 32 / Filled & Regular
	- Paint Brush Subtract / 16, 20, 24, 28, 32 / Filled & Regular
	- Paint Brush / 28 / Filled & Regular
	- Play Circle Sparkle / 16, 20, 24 / Filled & Regular
	- Replay / 16, 20, 24, 28, 32 / Filled & Regular
	- Send Person / 16, 20, 24 / Filled & Regular
	- Square Dovetail Joint / 12, 16, 20, 24, 28, 32, 48 / Filled & Regular
	- Table Cursor / 16, 20, 24 / Filled & Regular
	- Transparency Square / 20, 24 / Filled & Regular
 
	 **What's updated (Name / Size(s) / Variant(s))**
	- Notepad / 32 / Filled & Regular
	- Replay / 20 / Filled & Regular

## v3.7.1

### Components
- [Autocomplete] Accessibility: Tab key to go to the Close Button ([#2007](https://github.com/microsoft/fluentui-blazor/pull/2007))
- [Autocomplete] Add `ImmediateDelay` parameter ([#2052](https://github.com/microsoft/fluentui-blazor/pull/2052))
- [Autocomplete] Set the height automatically ([#2045](https://github.com/microsoft/fluentui-blazor/pull/2045))
- [DataGrid] give empty row an id ([#2001](https://github.com/microsoft/fluentui-blazor/pull/2001))
- [DataGrid] Prevent drag handle from disappearing when column width made too small (#[2059](https://github.com/microsoft/fluentui-blazor/pull/2059))
- [Dialog] Better a11y by adding aria-label to the close button.
- [InputBase] Use `Debouncer` instead of `PeriodicTimer` for debouncing `ValueChanged` handler with `ImmediateDelay`. ([#2042](https://github.com/microsoft/fluentui-blazor/pull/2042))
- [InputLabel] Add Orientation parameter  ([#1994](https://github.com/microsoft/fluentui-blazor/pull/1994))
- [Lists] Change Option<TType>.Text to `string?` ([#2063](https://github.com/microsoft/fluentui-blazor/pull/2063))
- [Option] Update the aria-selected item on FluentOption to apply the default style
- [Tabs] Prevent error 'An item with the same key has already been added.' ([#2006](https://github.com/microsoft/fluentui-blazor/pull/2006))
 
### Icons
- Update to Fluent UI System Icons 1.1.239 

	**What's new (Name / Size(s) / Variant(s))**
	- Arrow Turn Right / 16 / Filled & Regular
	- Chart Multiple / 16 / Filled & Regular
	- Column / 24 / Filled & Regular
	- Data Pie / 16 / Filled & Regular
	- Layout Column Two Focus Left / 32 / Filled
	- Layout Column Two Focus Right / 32 / Filled
	- Layout Column Two / 32 / Filled & Regular
	- Layout Row Two Focus Top / 32 / Filled
	- Layout Row Two / 32 / Filled & Regular
	- Mail Copy / 32 / Filled & Regular
	- Paint Brush Sparkle / 20, 24 / Filled & Regular
	- People Community / 12 / Filled & Regular
	- Person Board / 12 / Filled & Regular
	- Person Tentative / 16, 20, 24 / Filled & Regular
	- Tab Desktop Search / 16, 20, 24 / Filled & Regular
	- Table Sparkle / 20, 24 / Filled & Regular
 
	**What's updated (Name / Size(s) / Variant(s))**
	- Chart Multiple / 20, 24 / Filled & Regular
	- Column Edit / 24 / Filled & Regular
	- Data Pie / 24 / Filled & Regular   

## v3.7.0

### Demo site and documentation 
- [Docs] Update KeyCodeGlobalExample.razor.css to fix dark mode visuals ([#1834](https://github.com/microsoft/fluentui-blazor/pull/1834))

### Components
- [Badge] Fix displaying badge by not using a div (block element) in an inline element (#1921)([#1921](https://github.com/microsoft/fluentui-blazor/pull/1921))
- [DataGrid] Add column Width parameter ([#1902](https://github.com/microsoft/fluentui-blazor/pull/1902))
- [DataGrid] Add remove sort capability on columns ([#1826](https://github.com/microsoft/fluentui-blazor/pull/1826))
- [DataGrid] Add ShowHover parameter and implement row hover effect ([#1939](https://github.com/microsoft/fluentui-blazor/pull/1939))
- [DataGrid] Apply ItemSize (CSS height) to cells when grid is virtualized ([#1936](https://github.com/microsoft/fluentui-blazor/pull/1936))
- [DataGrid] Change column width when using generated value ([#1955](https://github.com/microsoft/fluentui-blazor/pull/1955))
- [DataGrid] Add resizing columns by keyboard ([#1866](https://github.com/microsoft/fluentui-blazor/pull/1866))
- [Grid] Add AdaptiveRendering property ([#1899](https://github.com/microsoft/fluentui-blazor/pull/1899))
- [Input] NotifyFieldChanged is called twice for all FluentInputBase derived components ([#1846](https://github.com/microsoft/fluentui-blazor/pull/1846))
- [KeyCode] Allow content to avoid using the Anchor property ([#1743](https://github.com/microsoft/fluentui-blazor/pull/1743))
- [KeyCode, AnchoredRegion, Popover] Add key navigation in AnchoredRegion / Popup ([#1800](https://github.com/microsoft/fluentui-blazor/pull/1800))
- **[KeyCodeProvider]** Add a global service to capture keystrokes ([#1740](https://github.com/microsoft/fluentui-blazor/pull/1740))
- [Lists] Also set Value (and InternalValue) when SelectedOption is set ([#1970](https://github.com/microsoft/fluentui-blazor/pull/1970))
- [NavMenu] Show child items via `FluentMenu` when collapsed ([#1730](https://github.com/microsoft/fluentui-blazor/pull/1730))
- [NavMenu] Fix keyboard navigation ([#1950](https://github.com/microsoft/fluentui-blazor/pull/1950))
- [Popover] adds FixedPlacement parameter ([#1894](https://github.com/microsoft/fluentui-blazor/pull/1894))
- [Tabs] Not using ClassValue and StyleValue when rendering ([#1931](https://github.com/microsoft/fluentui-blazor/pull/1931))

## v3.6.2

### Demo site and documentation 
- [Docs] Update Progress stroke examples dropdowns ([#1835](https://github.com/microsoft/fluentui-blazor/pull/1835))
- [Docs] Update Highlighter example to use FluentTextField instead of input ([#1833](https://github.com/microsoft/fluentui-blazor/pull/1833))

### Components
- [Input] NotifyFieldChanged is called twice for all FluentInputBase derived components ([#1846](https://github.com/microsoft/fluentui-blazor/pull/1846))
- [MenuButton] Add ChildContent so items can be supplied manually ([#1848](https://github.com/microsoft/fluentui-blazor/pull/1848))
- [Paginator] spelling issue in FluentPaginator.razor.cs ([#1829](https://github.com/microsoft/fluentui-blazor/pull/1829))
- [Popover] adds FixedPlacement parameter ([#1894](https://github.com/microsoft/fluentui-blazor/pull/1894))
- [Select] Allow value to be set when component is disabled ([#1892](https://github.com/microsoft/fluentui-blazor/pull/1892))
- [Slider] Fixes thumb redraw issues (Fix for #1836) ([#1873](https://github.com/microsoft/fluentui-blazor/pull/1873))

### Icons
- Update to Fluent UI System Icons 1.1.237 

	**What's new (Name / Size(s) / Variant(s))**
	- Book / 48 / Filled & Regular
	- Camera Arrow Up / 16, 20, 24 / Filled & Regular
	- Chat Settings / 16 / Filled & Regular
	- Circle Highlight / 20, 24 / Filled & Regular
	- Circle Hint / 24 / Filled & Regular
	- Circle Shadow / 20, 24 / Filled & Regular
	- Content View / 16 / Filled & Regular
	- Double Tap Swipe Down / 16 / Filled & Regular
	- Double Tap Swipe Up / 16 / Filled & Regular
	- Flash Sparkle / 16 / Filled & Regular
	- Location Ripple / 12 / Filled & Regular
	- Search Square / 16 / Filled & Regular
	- Settings Chat / 16 / Filled & Regular
	- Share Multiple / 16, 20, 24 / Filled & Regular
	- Slide Play / 20, 24 / Filled & Regular
 
	**What's updated (Name / Size(s) / Variant(s))**
	- Book Add / 28 / Filled & Regular
	- Book Contacts / 20, 24, 28, 32 / Filled & Regular
	- Book / 28 / Filled & Regular   


From now on we will just list the PRs that have been merged. The related issues can be found by looking at the PR details on GitHub.

Titles have been altered and sorted here to provide a bit more uniformity.

## V3.6.1
### Demo site, documentation and miscellaneous
- [Demo & docs] Add InputFile 'known issues' section ([#1680](https://github.com/microsoft/fluentui-blazor/pull/1680))
- [Demo & docs] Minor corrections to CONTRIBUTING.md ([#1681](https://github.com/microsoft/fluentui-blazor/pull/1681))
- [Misc] Add ToColorHex extension to Swatch ([#1691](https://github.com/microsoft/fluentui-blazor/pull/1691))
- [Misc] Rider files not ignored ([#1649](https://github.com/microsoft/fluentui-blazor/pull/1649))

### Components
- [Accordion] Add expanded value to custom event handler ([#1689](https://github.com/microsoft/fluentui-blazor/pull/1689))
- [Autocomplete] Add autofocus to Autocomplete & Combobox [#1650](https://github.com/microsoft/fluentui-blazor/pull/1650)
- [InputFile] Replace OnInitializedAsync with OnAfterRenderAsync ([#1661](https://github.com/microsoft/fluentui-blazor/pull/1661))
- [MenuButton] Make the menu anchored to the button so can float ([#1676](https://github.com/microsoft/fluentui-blazor/pull/1676)) 
- [Toast] Do not render percent sign for indeterminate ProgressToast (#1138)](https://github.com/microsoft/fluentui-blazor/pull/1138)

### Icons
- Update Fluent UI System Icons to 1.1.234

	**What's new (Name / Size(s) / Variant(s))**

	- Apps Settings / 16, 20 / Filled & Regular
	- Apps Shield / 16, 20 / Filled & Regular
	- Arrow Upload / 32 / Filled & Regular
	- Calendar Edit / 32 / Filled & Regular
	- Data Bar Vertical Arrow Down / 16, 20, 24 / Filled & Regular
	- Haptic Strong / 16, 20, 24 / Filled & Regular
	- Haptic Weak / 16, 20, 24 / Filled & Regular
	- Hexagon Sparkle / 20, 24 / Filled & Regular
	- Mail Edit / 32 / Filled & Regular
	- Password Clock / 48 / Filled & Regular
	- Password Reset / 48 / Filled & Regular
	- Password / 24, 32, 48 / Filled & Regular
	- People Eye / 16, 20 / Filled & Regular
	- Pin Globe / 16, 20 / Filled & Regular
	- Run / 28, 32, 48 / Filled & Regular
	- Tab Group / 16, 20, 24 / Filled & Regular

	**What's updated (Name / Size(s) / Variant(s))**
 
	- Arrow Upload / 24 / Filled & Regular
	- Calendar Edit / 16, 20, 24 / Filled & Regular
	- Mail Read / 20 / Filled & Regular
	- Password / 24 / Filled & Regular
	- Run / 16, 20, 24 / Filled & Regular
- Update Fluent UI System Icons to 1.1.233

  **What's new (Name / Size(s) / Variant(s))**
	- Classification / 32 / Filled & Regular
	- Document Target / 20, 24, 32 / Filled & Regular
	- Emoji Meme / 16, 20, 24 / Filled & Regular
	- Hand Point / 16, 20, 24, 28, 32, 48 / Filled & Regular
	- Mail Read Briefcase / 48 / Filled & Regular
	- People Subtract / 20, 24, 32 / Filled & Regular
	- Person Alert Off / 16, 20, 24, 32 / Filled & Regular
	- Shopping Bag Add / 16 / Filled & Regular
	- Spatula Spoon / 16, 20, 24, 28, 32, 48 / Filled & Regular
	- Accessibility Error / 20, 24 / Filled & Regular
	- Accessibility Question Mark / 20, 24 / Filled & Regular
	- Arrow Down Exclamation / 24 / Filled & Regular
	- Arrow Sort Up Lines / 16, 20, 24 / Filled & Regular
	- Arrow Up Exclamation / 16, 20, 24 / Filled & Regular
	- Bench / 20, 24 / Filled & Regular
	- Building Lighthouse / 28 / Filled & Regular
	- Clock Bill / 16, 20, 24, 32 / Filled & Regular
	- Data Usage Settings / 16, 24 / Filled & Regular
	- Data Usage / 16 / Filled & Regular
	- Edit Person / 20, 24 / Filled & Regular
	- Highway / 20, 24 / Filled & Regular
	- Laptop Person / 20, 24, 48 / Filled & Regular
	- Location Ripple / 16, 20, 24 / Filled & Regular
	- Mail Arrow Double Back / 32 / Filled & Regular
	- Mail Briefcase / 48 / Filled & Regular
	- People Add / 32 / Filled & Regular
	- Person Alert / 32 / Filled & Regular
	- Road / 20, 24 / Filled & Regular
	- Save / 32 / Filled & Regular
	- Tab Desktop Multiple Sparkle / 16, 20, 24 / Filled & Regular
	- Tab Desktop Multiple / 24 / Filled & Regular
	- Vehicle Tractor / 20, 24 / Filled & Regular
 
  **What's updated (Name / Size(s) / Variant(s))**
	- Classification / 20, 24 / Filled & Regular
	- Emoji Add / 20 / Filled & Regular
	- Emoji Edit / 20 / Filled & Regular
	- Emoji Sparkle / 20 / Filled & Regular
	- Emoji / 20 / Filled & Regular
	- Accessibility Checkmark / 24 / Filled & Regular
	- Arrow Down Exclamation / 16, 20 / Filled & Regular
	- Arrow Sort Down Lines / 16, 20, 24 / Filled & Regular
	- Building Lighthouse / 48 / Filled & Regular
	- Calendar Video / 20, 24, 28 / Filled & Regular
	- Options / 16, 28, 32 / Filled & Regular
	- Person Alert / 16, 20, 24 / Filled & Regular
	- Tab Desktop Multiple Bottom / 24 / Filled 

## V3.6.0
- [feat: Add autofocus to Autocomplete & Combobox (#1650)](https://github.com/microsoft/fluentui-blazor/pull/1650)
- [[FluentGrid] Fix the Grid "external margins" (#1646)](https://github.com/microsoft/fluentui-blazor/pull/1646)
- [Add VerticalThreshold to menu (#1644)](https://github.com/microsoft/fluentui-blazor/pull/1644)
- [Remove Expression from TooltipText (#1635)](https://github.com/microsoft/fluentui-blazor/pull/1635)
- [Fix bug in FluentPersona when the names contains more than one space. (#1623)](https://github.com/microsoft/fluentui-blazor/pull/1623)
- [Adds a Filtered property and visual indicator to PropretyColumn in FluentDataGrid (#1625)](https://github.com/microsoft/fluentui-blazor/pull/1625)
- [Fix native autocomplete for combobox (#1629)](https://github.com/microsoft/fluentui-blazor/pull/1629)
- [Add .resizable class to header cell when ResizableColumns is true (#1606)](https://github.com/microsoft/fluentui-blazor/pull/1606)
- [[FluentCard] Add MinimalStyle property (#1595) ](https://github.com/microsoft/fluentui-blazor/pull/1595)
- [MenuButton changes and additions (#1602) ](https://github.com/microsoft/fluentui-blazor/pull/1602)
- [Update the FluentButton custom style for BackgroundColor and Color properties (#1603)](https://github.com/microsoft/fluentui-blazor/pull/1603)
- [Fix #1582 by adding pointercancel and pointerleave event listeners (#1591](https://github.com/microsoft/fluentui-blazor/pull/1591)
- [feat: Add global search bar (#1583)](https://github.com/microsoft/fluentui-blazor/pull/1583)
- [refactor: Migrate Demo Search to use FluentAutocomplete (#1599)](https://github.com/microsoft/fluentui-blazor/pull/1599)
- [Add LoadingContent parameter to FluentTab (#1587)](https://github.com/microsoft/fluentui-blazor/pull/1587)
- [Fix OnRowwFocus and sorting for DataGrid (#1577)](https://github.com/microsoft/fluentui-blazor/pull/1577)
- [FluentMenu fixes (#1574) ](https://github.com/microsoft/fluentui-blazor/pull/1574)
- [Render out Id for FluentNavLink + add test (#1580)](https://github.com/microsoft/fluentui-blazor/pull/1580)
- [Fix #1531 by using web components current-value instead of value. (#1576)](https://github.com/microsoft/fluentui-blazor/pull/1576)
- [Add IconDismiss adn IconSearch (#1573) ](https://github.com/microsoft/fluentui-blazor/pull/1573)
- [[FluentTooltip] Add the HideTooltipOnCursorLeave property (#1571)](https://github.com/microsoft/fluentui-blazor/pull/1571)
- [[FluentSplashScreen] Add WaitingMilliseconds and UpdateLabels (#1570) ](https://github.com/microsoft/fluentui-blazor/pull/1570)
- [Fix Loading issues (#1512)](https://github.com/microsoft/fluentui-blazor/pull/1512)
- [Add FluentKeyCode.PreventDefaultOnly and fix the Autocomplete Backspace keycode (#1544)](https://github.com/microsoft/fluentui-blazor/pull/1544)
- [fix: add required binding to the autocomplete label (#1543)](https://github.com/microsoft/fluentui-blazor/pull/1543)
- [Fix Icon color using ColorWith and a CustomColor attribute (#1539)](https://github.com/microsoft/fluentui-blazor/pull/1539)
- [Update NavMenuPage.razor (#1518) ](https://github.com/microsoft/fluentui-blazor/pull/1518)

- Update Fluent UI System Icons to 1.1.230

  **What's new (Name / Size(s) / Variant(s))**
- Checkmark Circle Warning / 16, 20, 24 / Filled & Regular
- Cloud Arrow Right / 16, 20, 24 / Filled & Regular
- Document Arrow Down / 24 / Filled & Regular
- Document Signature / 16, 20, 24, 28, 32, 48 / Filled & Regular
- Home Garage / 20, 24 / Filled & Regular
- Image Split / 20, 24 / Filled & Regular
- Laptop / 48 / Filled & Regular
- Line Flow Diagonal Up Right / 16, 20, 24, 32 / Filled & Regular
- Mail Arrow Clockwise / 16, 20, 24 / Filled & Regular
- Person Passkey / 16, 20, 24, 28, 32, 48 / Filled & Regular
- Person Prohibited / 32 / Filled & Regular
- Person Ribbon / 24 / Filled & Regular
- Plant Cattail / 20, 24 / Filled & Regular
- Storage / 16, 28, 32, 48 / Filled & Regular
- Video Clip Wand / 16, 20, 24 / Filled & Regular
- Window Fingerprint / 16, 20, 24, 28, 32, 48 / Filled & Regular
 
  **What's updated (Name / Size(s) / Variant(s))**
- Video Add / 20, 24 / Filled & Regular

## V3.5.5
- Issue [#1437](https://github.com/microsoft/fluentui-blazor/issues/1437): UI does not leave Loading animation if result has 0 items in FluentDataGrid 
- Issue [#1424](https://github.com/microsoft/fluentui-blazor/issues/1424): Not setting current-value for fluent-number-field
- Issue [#1425](https://github.com/microsoft/fluentui-blazor/issues/1425): add OnClick EventCallback to FluentAnchor
- Issue [#1462](https://github.com/microsoft/fluentui-blazor/issues/1462): FluentMessageBar onclick bug and not using Link?.Target
- Issue [#1450](https://github.com/microsoft/fluentui-blazor/issues/1450): FluentSlider's two-way data binding on Value Property does not update appropriately
- Issue [#1448](https://github.com/microsoft/fluentui-blazor/issues/1448): two key strokes required to change item in FluentSelect
- Issue [#1449](https://github.com/microsoft/fluentui-blazor/issues/1449): [Autocomplete] Fix Disabled item using keyboard and re-enables the ability to click on an element

## V3.5.4
- Issue [#1417](https://github.com/microsoft/fluentui-blazor/issues/1417): Fix Autocomplete Enter key in EditForm
- Issue [#1414](https://github.com/microsoft/fluentui-blazor/issues/1414): NavMenu / KeyCode optimizations
- Issue [#1413](https://github.com/microsoft/fluentui-blazor/issues/1413): Add TooltipService.Refresh method
- Issue [#1411](https://github.com/microsoft/fluentui-blazor/issues/1411): Add inputmode attribute support for FluentTextField
- Issue [#1408](https://github.com/microsoft/fluentui-blazor/issues/1408): Add StopPropagation and TargetId
- Issue [#1404](https://github.com/microsoft/fluentui-blazor/issues/1404): [FluentFileInput] adds a "disabled" property to the FluentFileInput component
- Issue [#1402](https://github.com/microsoft/fluentui-blazor/issues/1402): Fix missing Checkbox "disabled" class
- Issue [#1393](https://github.com/microsoft/fluentui-blazor/issues/1393): Use FluentKeyCode for NavMenu 
- Issue [#1386](https://github.com/microsoft/fluentui-blazor/issues/1386): [InputLabel] Fix clicking on required label (*) does not focus input element
- Issue [#1385](https://github.com/microsoft/fluentui-blazor/issues/1385): Add Overflow RemoveItem method
- Issue [#1384](https://github.com/microsoft/fluentui-blazor/issues/1384): Add Popover Threshold attributes
- Issue [#1383](https://github.com/microsoft/fluentui-blazor/issues/1383): [Accessibility] Autocomplete - Fix up/down arrow and labels for screen reader

- Update Fluent UI System Icons to 1.1.226
	**What's new (Name / Size(s) / Variant(s))**
	- Building Lighthouse / 24, 32, 48 / Filled & Regular
	- Calendar Link / 24, 28 / Filled & Regular
	- Calendar Video / 24, 28 / Filled & Regular
	- Cookies / 16, 28, 32, 48 / Filled & Regular
	- Hard Drive / 28, 48 / Filled & Regular
	- Laptop Settings / 20, 24, 32 / Filled & Regular
	- Laptop / 32 / Filled & Regular
	- People Audience / 32 / Filled & Regular
	- Shopping Bag Add / 20, 24 / Filled & Regular
	- Street Sign / 20, 24 / Filled & Regular
	- Video Link / 24, 28 / Filled & Regular

	**What's updated (Name / Size(s) / Variant(s))**
	- Cube / 12 / Filled & Regular
	- Laptop Multiple / 24 / Filled & Regular
	- Laptop / 24, 28 / Filled & Regular
	- Prohibited Multiple / 28 / Filled & Regular

## V3.5.3
- PR [#1372](https://github.com/microsoft/fluentui-blazor/pull/1372): List related refactoring and maintenance (#1372)
- Issue [#1344](https://github.com/microsoft/fluentui-blazor/issues/1344): Fix #1344 for Items based lists (#1356)
- Issue [#1317](https://github.com/microsoft/fluentui-blazor/issues/1317):[DataGrid] - Add Loading and LoadingContent parameters (#1368)
- Issue [#1311](https://github.com/microsoft/fluentui-blazor/issues/1311): Fix problems with validation border color / validation classes (#1348)
- Issue [#1292](https://github.com/microsoft/fluentui-blazor/issues/1292): Accessibility issue in Fluent AutoComplete

- Update Fluent UI System Icons to version 1.1.225
	
	**What's new (Name / Size(s) / Variant(s))**
	- Flowchart / 16, 32 / Filled & Regular
	- Layer Diagonal Person / 24 / Filled & Regular
	- Layer Diagonal / 24 / Filled & Regular
	- Poll Off / 16, 20, 24, 32 / Filled & Regular
	- Rectangle Landscape Sparkle / 48 / Filled & Regular
	- Rectangle Landscape Sync Off / 16, 20, 24, 28 / Filled & Regular
	- Rectangle Landscape Sync / 16, 20, 24, 28 / Filled & Regular
	- Seat Add / 16, 20, 24 / Filled & Regular
	- Seat / 16, 20, 24 / Filled & Regular
	- Speaker / 16, 20, 24 / Filled & Regular
	- Text Edit Style Character Ga / 32 / Filled & Regular
	- Window Ad / 24 / Filled & Regular
	- Wrench Settings / 20, 24 / Filled & Regular
	
	**What's updated (Name / Size(s) / Variant(s))**
	- Add Circle / 32 / Filled & Regular
	- Arrow Clockwise Dashes / 16, 20, 24, 32 / Filled & Regular
	- Arrow Clockwise / 16, 20, 24, 28, 32, 48 / Filled & Regular
	- Arrow Counterclockwise Dashes / 20, 24 / Filled & Regular
	- Arrow Counterclockwise / 16, 20, 24, 28, 32, 48 / Filled & Regular
	- Arrow Reply All / 16, 20, 24, 28, 32, 48 / Filled & Regular
	- Arrow Reply Down / 16, 20, 24 / Filled & Regular
	- Arrow Reply / 16, 20, 24, 28, 32, 48 / Filled & Regular
	- Calendar Clock / 24 / Filled & Regular
	- Calendar Info / 16 / Filled & Regular
	- Calendar Lock / 16 / Filled & Regular
	- Calendar Person / 16 / Filled & Regular
	- Calendar Phone / 16 / Filled & Regular
	- Calendar Question Mark / 16 / Filled & Regular
	- Calendar Reply / 16 / Filled & Regular
	- Calendar Search / 16 / Filled & Regular
	- Calendar Settings / 16 / Filled & Regular
	- Calendar Shield / 16 / Filled & Regular
	- Calendar Star / 16 / Filled & Regular
	- Calendar Sync / 16 / Filled & Regular
	- Chat Add / 16, 20, 24, 28, 32, 48 / Filled & Regular
	- Cloud Archive / 28, 48 / Filled & Regular
	- Cloud Arrow Down / 28, 48 / Filled & Regular
	- Cloud Arrow Up / 28, 48 / Filled & Regular
	- Cloud Beaker / 28, 48 / Filled & Regular
	- Cloud Checkmark / 28, 48 / Filled & Regular
	- Cloud Cube / 28, 48 / Filled & Regular
	- Cloud Dismiss / 28, 48 / Filled & Regular
	- Cloud Error / 28, 48 / Filled & Regular
	- Cloud Off / 28, 48 / Filled & Regular
	- Cloud Sync / 28, 48 / Filled & Regular
	- Cloud Words / 28, 48 / Filled & Regular
	- Cloud / 28, 48 / Filled & Regular
	- Comment Multiple Checkmark / 16, 20, 24, 28 / Filled & Regular
	- Comment Multiple Link / 16, 20, 24, 28, 32 / Filled & Regular
	- Comment Multiple / 16, 20, 24, 28, 32 / Filled & Regular
	- Credit Card Clock / 24 / Filled & Regular
	- Document Search / 20, 24 / Filled & Regular
	- Document Text Clock / 24 / Filled & Regular
	- Flag Clock / 20, 24 / Filled & Regular
	- Flag Off / 20 / Filled & Regular
	- Flag / 20 / Filled & Regular
	- Globe Clock / 24 / Filled & Regular
	- History Dismiss / 20, 24, 28, 32, 48 / Filled & Regular
	- History / 16, 20, 24, 28, 32, 48 / Filled & Regular
	- Lock Closed Key / 16, 20, 24 / Filled & Regular
	- Mail Clock / 24 / Filled & Regular
	- Person Clock / 24 / Filled & Regular
	- Prohibited Multiple / 16, 20, 24 / Filled & Regular
	- Rectangle Landscape Sparkle / 16, 20, 24, 28, 32 / Filled & Regular
	- Scan Person / 16, 20, 24, 28, 48 / Filled & Regular
	- Search Info / 24 / Filled & Regular
	- Search / 24, 28 / Filled & Regular
	- Send Clock / 24 / Filled & Regular
	- Text Edit Style Character A / 32 / Filled
	- Vehicle Car Profile LTR Clock / 24 / Filled & Regular
	- Video Person Clock / 24 / Filled & Regular
	- Video Person Sparkle Off / 20, 24 / Filled & Regular
	- Video Person Sparkle / 16, 20, 24, 28, 48 / Filled & Regular
	- Window Ad Off / 20 / Filled
	- Window Ad / 20 / Filled
	- Window Console / 20 / Filled
	- Window Dev Edit / 16, 20 / Filled & Regular
	- Window Dev Tools / 16, 20, 24 / Filled & Regular
	- Window Edit / 16 / Filled & Regular
	- Window Shield / 16, 20, 24 / Filled & Regular
	- Wrench / 24 / Filled & Regular

## V3.5.2
- Issue [#1333](https://github.com/microsoft/fluentui-blazor/issues/1333): FluentSwitch inside FluentTab does not work anymore (revert #1194)

## V3.5.1
- Issue [#1323](https://github.com/microsoft/fluentui-blazor/issues/1323): Rapidly clicking between UI component throws Microsoft.JSInterop.JSException
- Issue [#1319](https://github.com/microsoft/fluentui-blazor/issues/1319): Fix FluentCheckbox issue
- Issue [#1324](https://github.com/microsoft/fluentui-blazor/issues/1324): Fix JustifyContent enum documentation description
- Issue [#1314](https://github.com/microsoft/fluentui-blazor/issues/1314): Updating FluentTabs ActiveTabId doesn't rerender if data is entered in contained FluentTextInput
- Issue [#1306](https://github.com/microsoft/fluentui-blazor/issues/1306): Better fix for #1205 / #1225 which fixes #1294
- Issue [#1305](https://github.com/microsoft/fluentui-blazor/issues/1305): Combobox component resetting bound object to null when custom content is entered 
- Issue [#1283](https://github.com/microsoft/fluentui-blazor/issues/1283): Fix Combobox and Select width property 
- Issue [#1279](https://github.com/microsoft/fluentui-blazor/issues/1279): Fix Combobox width without a important mark 
- Issue [#1278](https://github.com/microsoft/fluentui-blazor/issues/1278): Add Id to Anchor
- Issue [#1276](https://github.com/microsoft/fluentui-blazor/issues/1276): FluentTabs shows badge although all tabs are visible
- Issue [#1274](https://github.com/microsoft/fluentui-blazor/issues/1274): Width less than 250px does not take effect] in [FluentCombobox and FluentSelect
- Issue [#1273](https://github.com/microsoft/fluentui-blazor/issues/1273): Change CalendarDay IsSelected logic
- Issue [#1270](https://github.com/microsoft/fluentui-blazor/issues/1270): Optimize Dialog CloseAsync Method
- Issue [#1267](https://github.com/microsoft/fluentui-blazor/issues/1267): Add id parameter to FluentCard and FluentStack
- Issue [#1250](https://github.com/microsoft/fluentui-blazor/issues/1250): Fix paginator icons in RTL
- Issue [#1247](https://github.com/microsoft/fluentui-blazor/issues/1247): FluentNavMenu Add OnClick invoke to OnClickHandler 
- Issue [#1242](https://github.com/microsoft/fluentui-blazor/issues/1242): Implement OnDialogClosing and OnDialogOpened
- Issue [#1227](https://github.com/microsoft/fluentui-blazor/issues/1227): FluentTreeItem in that span that renders Text proprty is not conditional and adds unnecessary space when gap githubproperty is applied
- Issue [#1226](https://github.com/microsoft/fluentui-blazor/issues/1226): FluentAutocomplete does not have an ElementReference
- Issue [#1215](https://github.com/microsoft/fluentui-blazor/issues/1215): FluentTextField ignores DataList property
- Issue [#1205](https://github.com/microsoft/fluentui-blazor/issues/1205): Slider label max-width set to 30px
- Issue [#1204](https://github.com/microsoft/fluentui-blazor/issues/1204): FluentButton submit does not work outside the EditFor
- Issue [#1194](https://github.com/microsoft/fluentui-blazor/issues/1194): FluentTextField inside FluentTabs, pressing Enter re-renders FluentTab's content
- Issue [#1189](https://github.com/microsoft/fluentui-blazor/issues/1189): Combobox z-index stack order issue
- Issue [#1177](https://github.com/microsoft/fluentui-blazor/issues/1177): Update outdated W3.org link
- Issue [#1168](https://github.com/microsoft/fluentui-blazor/issues/1168): Tabs tablist will forever expand despite the tab containers width
- Issue [#1169](https://github.com/microsoft/fluentui-blazor/issues/1169): NavMenu: don't set background on selected active link
- Issue [#1144](https://github.com/microsoft/fluentui-blazor/issues/1144): List components: Each item must be instantiated (cannot be null).
- [FluentProgress] Add Width, Stroke, Color and BackgroundColor attributes
- [FluentDialog]Fix broken in published release build
- [FluentOverflow] Resize when a new element is included or excluded

## V3.5.0
- New: FluentValidationMessage and Required indicator for input components
- NavMenu: Tooltips. Expand on click when collapsed)
- InputFile: ProgressTEmplate and ProgressPercentage bindable
- List components: OptionTemplate
- Grid: Hiding elements and `OnBreakpointEnter` event callback
- Checkbox: Three state behavior			
- Splitter: Panel1MinSize, Panel2MinSie, BarSize, OnColllapsed, OnExpanded, OnResized
- Paginator: PaginationTextTemplate
- Fix [#1057](https://github.com/microsoft/fluentui-blazor/issues/1057): Can't show Fluent UI Blazor dialog on published Blazor webasm app
- Fix [#1070](https://github.com/microsoft/fluentui-blazor/issues/1070): Style not applied for FluentPaginator + added `PaginationTextTemplate` parameter 
- Update Fluent UI System Icons to version 1.1.224

- **What's new (Name / Size(s) / Variant(s))**
- Arrow Clockwise Dashes / 16, 32 / Filled & Regular
- Building Swap / 16, 20, 24, 32, 48 / Filled & Regular
- Certificate / 32 / Filled & Regular
- Clipboard Brush / 16, 20, 24, 28, 32 / Filled & Regular
- Cloud Beaker / 16, 20, 24, 28, 32, 48 / Filled & Regular
- Cloud Cube / 16, 20, 24, 28, 32, 48 / Filled & Regular
- Contract Up Right / 16, 20, 24, 28, 32, 48 / Filled & Regular
- Document Data Lock / 16, 20, 24, 32 / Filled & Regular
- Glance Horizontal Sparkles / 20 / Filled & Regular
- Layout Cell Four Focus Bottom Left / 16, 20, 24 / Filled
- Layout Cell Four Focus Bottom Right / 16, 20, 24 / Filled
- Layout Cell Four Focus Top Left / 16, 20, 24 / Filled
- Layout Cell Four Focus Top Right / 16, 20, 24 / Filled
- Layout Cell Four / 16, 20, 24 / Filled & Regular
- Layout Column Four Focus Center Left / 16, 20, 24 / Filled
- Layout Column Four Focus Center Right / 16, 20, 24 / Filled
- Layout Column Four Focus Left / 16, 20, 24 / Filled
- Layout Column Four Focus Right / 16, 20, 24 / Filled
- Layout Column Four / 16, 20, 24 / Filled & Regular
- Layout Column One Third Left / 16, 20, 24 / Filled & Regular
- Layout Column One Third Right Hint / 16, 20, 24 / Filled & Regular
- Layout Column One Third Right / 16, 20, 24 / Filled & Regular
- Layout Column Three Focus Center / 16, 20, 24 / Filled
- Layout Column Three Focus Left / 16, 20, 24 / Filled
- Layout Column Three Focus Right / 16, 20, 24 / Filled
- Layout Column Three / 16, 20, 24 / Filled & Regular
- Layout Column Two Focus Left / 16, 20, 24 / Filled
- Layout Column Two Focus Right / 16, 20, 24 / Filled
- Layout Column Two Split Left Focus Bottom Left / 16, 20, 24 / Filled
- Layout Column Two Split Left Focus Right / 16, 20, 24 / Filled
- Layout Column Two Split Left Focus Top Left / 16, 20, 24 / Filled
- Layout Column Two Split Left / 16, 20, 24 / Filled & Regular
- Layout Column Two Split Right Focus Bottom Right / 16, 20, 24 / Filled
- Layout Column Two Split Right Focus Left / 16, 20, 24 / Filled
- Layout Column Two Split Right Focus Top Right / 16, 20, 24 / Filled
- Layout Column Two Split Right / 16, 20, 24 / Filled & Regular
- Layout Column Two / 16, 20, 24 / Filled & Regular
- Layout Row Four Focus Bottom / 16, 20, 24 / Filled
- Layout Row Four Focus Center Bottom / 16, 20, 24 / Filled
- Layout Row Four Focus Center Top / 16, 20, 24 / Filled
- Layout Row Four Focus Top / 16, 20, 24 / Filled
- Layout Row Four / 16, 20, 24 / Filled & Regular
- Layout Row Three Focus Bottom / 16, 20, 24 / Filled
- Layout Row Three Focus Center / 16, 20, 24 / Filled
- Layout Row Three Focus Top / 16, 20, 24 / Filled
- Layout Row Three / 16, 20, 24 / Filled & Regular
- Layout Row Two Focus Bottom / 16, 20, 24 / Filled
- Layout Row Two Focus Top / 16, 20, 24 / Filled
- Layout Row Two Split Bottom Focus Bottom Left / 16, 20, 24 / Filled
- Layout Row Two Split Bottom Focus Bottom Right / 16, 20, 24 / Filled
- Layout Row Two Split Bottom Focus Top / 16, 20, 24 / Filled
- Layout Row Two Split Bottom / 16, 20, 24 / Filled & Regular
- Layout Row Two Split Top Focus Bottom / 16, 20, 24 / Filled
- Layout Row Two Split Top Focus Top Left / 16, 20, 24 / Filled
- Layout Row Two Split Top Focus Top Right / 16, 20, 24 / Filled
- Layout Row Two Split Top / 16, 20, 24 / Filled & Regular
- Layout Row Two / 16, 20, 24 / Filled & Regular
- Location Target Square / 16, 20, 24, 32 / Filled & Regular
- Resize / 16, 28, 32, 48 / Filled & Regular
- Select All Off / 16 / Filled & Regular
- Select All On / 16 / Filled & Regular
- Share Android / 16, 32 / Filled & Regular
- Text Arrow Down Right Column / 16, 20, 24, 28, 32, 48 / Filled & Regular
- Text Effects Sparkle / 20, 24 / Filled & Regular
- Whiteboard Off / 16, 20, 24 / Filled & Regular
- Whiteboard / 16 / Filled & Regular
 
**What's updated (Name / Size(s) / Variant(s))**
- Contract Down Left / 28 / Filled & Regular
- Resize / 20, 24 / Filled & Regular
- Select All Off / 20, 24 / Filled & Regular
- Select All On / 20, 24 / Filled & Regular

## V3.4.1
- Fix [#1040](https://github.com/microsoft/fluentui-blazor/issues/1040): `FluentNumberField` can be changed when `ReadOnly`
- Fix [#917](https://github.com/microsoft/fluentui-blazor/issues/917) Multiple `Header` and `Footer` detection in Dialog
- Fix [#939](https://github.com/microsoft/fluentui-blazor/issues/939): Add `OptionTemplate` for `FluentCombobox`, `FluentListBox` and `FluentSelect` 
- FluentNavMenu: Add `Tooltip` parameter to `FluentNavMenuGroup` (fallback to `Title`) and `FluentNavLink`
- FluentNavMenu: Expand the menu when collapsed and a navitem is clicked 
- FluentInputFile: Add ProgressTemplate and a bindable ProgressPercent attribute

## V3.4.0
- FluentCheckbox: Add tri-state support
- FluentAccordionItem: Add HeaderTemplate parameter
- FluentSplitter: Add Panel1MinSize, Panel2MinSize and BarSize parameter. 
- FluentSplitter: Make resizing always use proportional values
- FluentSplitter: Add support for collapsing panel 2 (right/bottom), add `OnCollapsed`, `OnExpanded` and  `OnResized` event callbacks
- Fix using checkbox, switch, slider being used in `EditForm` not getting set on first clicks
- Move CacheStorageAccessor and StaticAssetService to Demo.Shared project as these are specific to the demo site and not the library
- Update Fluent UI System Icons to 1.1.223
- Demo: Move ErrorBoundry into DemoSection component so pagge keeps working when only one section fails

## V3.3.0
- This version no longer supports .NET 8.0 (use `Microsoft.FluentUI.AspNetCore.Components` in that case)
- Update all input component to use `ReadOnly` instead of a mix of possible spellings
- Update demo site styling (nav menu and body now scroll independently)
- Support DisabledDateFunc in FluentDatePicker 
- Fix [#911](https://github.com/microsoft/fluentui-blazor/issues/91	1): Column resizing in DataGrid breaks when column to narrow

## V3.2.3
- Fix [#891](https://github.com/microsoft/fluentui-blazor/issues/891): JSDisconnectedException in FluentOverflow
- Fix [#861](https://github.com/microsoft/fluentui-blazor/issues/861): Needed extra `empty-content-cell` class 
- FluentCard: Add Width and Height + docs/examples

## V3.2.2
- Fix [#859](https://github.com/microsoft/fluentui-blazor/issues/859) and [#884](https://github.com/microsoft/fluentui-blazor/issues/859): Fix NavMenu for real by moving `<a>` tag up in the rendering tree

### Update Fluent UI System icons to 1.1.221
**What's new (Name / Size(s) / Variant(s))**
- Arrow Download Off / 16, 20, 24, 28, 32, 48 / Filled & Regular
- Border Inside / 16, 20, 24 / Filled & Regular
- Chat Lock / 16, 20, 24, 28 / Filled & Regular
- Error Circle / 48 / Filled & Regular
- Full Screen Maximize / 28, 32 / Filled & Regular
- Full Screen Minimize / 28, 32 / Filled & Regular
- Link Person / 16, 20, 24, 32, 48 / Filled & Regular
- People Chat / 16, 20, 24 / Filled & Regular
- Person Support / 28 / Filled & Regular
- Shapes / 32 / Filled & Regular
- Slide Text Edit / 16, 20, 24, 28 / Filled & Regular
- Subtract Circle / 48 / Filled & Regular
- Subtract Parentheses / 16, 20, 24, 28, 32, 48 / Filled & Regular
- Warning / 48 / Filled & Regular

**What's updated (Name / Size(s) / Variant(s))**
- Border None / 16 / Filled & Regular
- Flag Off / 48 / Filled & Regular
- Person Support / 16, 20, 24 / Filled & Regular
- Shapes / 28 / Filled & Regular
- Subtract Circle / 16, 32 / Filled & Regular

## V3.2.1
- Design Tokens WithDefault method implemented to allow setting a default value for a token. This is technically a breaking chage, but it is unlikely to affect anyone as the previous implementation did not do anything. See the `SiteSettingsPanel.razor.cs` in the demo site for an implementation example.
- Fix [#872](https://github.com/microsoft/fluentui-blazor/issues/872): A11y issue in FluentDivider
- Fix [#864](https://github.com/microsoft/fluentui-blazor/issues/864): A11y issue in FluentAutoComplete
- Fix [#861](https://github.com/microsoft/fluentui-blazor/issues/861): A11y issue in FluentDataGrid EmptyContent
- Fix [#848](https://github.com/microsoft/fluentui-blazor/issues/848): A11y issue in FluentDialogHeader
- Fix [#847](https://github.com/microsoft/fluentui-blazor/issues/847): A11y issues in FluentNavMenu
- Fix [#861](https://github.com/microsoft/fluentui-blazor/issues/861): A11y issue in FluentDataGrid EmptyContent
- Fix [#859](https://github.com/microsoft/fluentui-blazor/issues/859): Fix FluentNavMenuGroup not clickable ouside of `<a>` tag
- Fix [#857](https://github.com/microsoft/fluentui-blazor/issues/857): Fix copy Emoji code in search page
- Fix [#841](https://github.com/microsoft/fluentui-blazor/issues/841): Overflow causes loss of background with Panel
- Fix [#833](https://github.com/microsoft/fluentui-blazor/issues/833): Use correct abbreviation for day name in FluentCalendar (Chinese)
- Miscelaneous documentation and typo fixes
- Add more unit tests
- Update to FluentUI System Icons 1.1.220

- **What's new (Name / Size(s) / Variant(s))**
- Arrow Download / 28, 32 / Filled & Regular
- Arrow Expand / 16 / Filled & Regular
- Arrow Export Up / 16 / Filled & Regular
- Arrow Import / 16 / Filled & Regular
- Arrow Up Right Dashes / 16 / Filled & Regular
- Battery 10 / 16 / Filled & Regular
- Beaker Empty / 16 / Filled & Regular
- Book / 16 / Filled & Regular
- Border None / 16 / Filled & Regular
- Branch Request / 16 / Filled & Regular
- Clipboard Task List / 16 / Filled & Regular
- Cut / 16 / Filled & Regular
- Folder Search / 16, 20, 24 / Filled & Regular
- Hexagon / 28, 32, 48 / Filled & Regular
- Plug Connected / 16 / Filled & Regular
- Plug Disconnected / 16 / Filled & Regular
- Projection Screen Text / 20 / Filled & Regular
- RSS / 16 / Filled & Regular
- Shape Organic / 16, 20, 24, 28, 32, 48 / Filled & Regular
- Teardrop Bottom Right / 16, 20, 24, 28, 32, 48 / Filled & Regular
- Text Asterisk / 16 / Filled & Regular
- Text Edit Style / 16 / Filled & Regular
- Text Whole Word / 16 / Filled & Regular
- Triangle / 24, 28 / Filled & Regular
  
**What's updated (Name / Size(s) / Variant(s))**
- Arrow Bidirectional Left Right / 16 / Filled & Regular
- Arrow Download / 24, 48 / Filled & Regular
- Beaker Edit / 20 / Filled & Regular
- Beaker Off / 20 / Filled & Regular
- Beaker Settings / 20 / Filled & Regular
- Clipboard Letter / 24 / Filled & Regular
- Prohibited / 16, 24, 28, 48 / Filled & Regular 
## V3.2.0
- New NavMenu, NavGroup and NavLink components. **Breaking change** - See the [Upgrade guide](https://www.fluentui-blazor.net/UpgradeGuide) for details. See [NavMenu](https://www.fluentui-blazor.net/NavMenu) page for examples.
- New FluentInputLabel component. 
- FluentCard: Add AreaRestricted parameter to allow content to break out of card area.
- Provide error message when FluentDialogProvider missing
- It is now possible to add a tooltip to DataGridColumns
- 
- Fix [#796](https://github.com/microsoft/fluentui-blazor/pull/796): Fix IconColor doc page
- Fix [#797](https://github.com/microsoft/fluentui-blazor/pull/797): Fix MessageBar issues
- Fix [#805](https://github.com/microsoft/fluentui-blazor/pull/805): InlineStyleBuilder on .NET6
- Fix [#810](https://github.com/microsoft/fluentui-blazor/pull/810): FluentDataGrid error if page is quickly exited
- Fix [#815](https://github.com/microsoft/fluentui-blazor/pull/815): Manual upload on iOS
- Fix [#828](https://github.com/microsoft/fluentui-blazor/pull/828): FluentSelect: Fix ValueChanged fired twice
- Fix [#801](https://github.com/microsoft/fluentui-blazor/pull/801): Remove direct call to Items.Count()
- Fix [#834](https://github.com/microsoft/fluentui-blazor/pull/834): Chinese abbreviated day name in FluentCalendar
- Fix [#836](https://github.com/microsoft/fluentui-blazor/pull/836): Setting SelectedOptions does not update FluentSelct

## V3.1.1
- Fix [#776](https://github.com/microsoft/fluentui-blazor/issues/776): Icon throws exception when deployed to Azure
- Fix [#755](https://github.com/microsoft/fluentui-blazor/issues/755): Icon throws exception when deployed to Azure
- Fix [#789](https://github.com/microsoft/fluentui-blazor/issues/789): Navigation to "/" crashes with FluentNavMenu
- Fix [#780](https://github.com/microsoft/fluentui-blazor/issues/780): 'OK' button rendered outside of panel for Site settings
Also addresses some other padding and layout issues with FluentDialog variants introduced in 3.1.0
- Feature [#782](https://github.com/microsoft/fluentui-blazor/issues/782) Add ability to prevent dismissing a modal dialog by clicking on the overlay
- Added `Tooltip` and `Style` parameters to DataGrid's `PropertyColumn` and `TemplateColumn`. See [DataGrid](https://www.fluentui-blazor.net) page for examples.
- Add Icon.WithColor and update the Demo page
- Update Button Icon Color depending of Button Appearance
- Update the way to apply the Icon.Color in a Button

## V3.1.

### New components
* `FluentAutoComplete`
* `FluentPersona`
* `FluentMessageBar`

### What's Changed

#### Components
* [FluentButton] Update the Button.Loading when using with a Icon by @dvoituron in https://github.com/microsoft/fluentui-blazor/pull/752
* [FluentCodeEditor] update docs by @vnbaaij in https://github.com/microsoft/fluentui-blazor/pull/692
* [FluentCombobox, FluentSelect, FluentListbox] Add Width and Height property and associated styles by @dvoituron in https://github.com/microsoft/fluentui-blazor/pull/663
* [FluentDataGrid] Add `EmptyContent` parameter by @vnbaaij in https://github.com/microsoft/fluentui-blazor/pull/731
* [FluentDataGrid] multiline-text word-break by @ssccinng in https://github.com/microsoft/fluentui-blazor/pull/711
* [FluentDataGridCell, FluentDataGridRow] Add item reference (#695) by @hksalessio in https://github.com/microsoft/fluentui-blazor/pull/700
* [FluentDataGridRow] Update for sticky header and example by @vnbaaij in https://github.com/microsoft/fluentui-blazor/pull/747
* [FluentDatePicker and FluentTimePicker] Keep existing time/date by @dvoituron in https://github.com/microsoft/fluentui-blazor/pull/726
* [FluentDatePicker] Update the popup position by @dvoituron in https://github.com/microsoft/fluentui-blazor/pull/724
* [FluentDialog] Dialog enhancements (add dialog type, fix panel width setable), 
* [FluentDialog] Enhancements by @vnbaaij in https://github.com/microsoft/fluentui-blazor/pull/717
* [FluentDialog] Include components to customize the Dialog-box by @dvoituron in https://github.com/microsoft/fluentui-blazor/pull/764
* [FluentDialog] Make all DialogService.Show..Async methods return IDialogReference by @vnbaaij in https://github.com/microsoft/fluentui-blazor/pull/694
* [FluentMenu/FluentPopover/FluentOverlay] Close menu/popover automatically when user clicks outside of it (by using overlay) by @vnbaaij in https://github.com/microsoft/fluentui-blazor/pull/729
* [FluentNavMenu] Fix route/subroute not selecting correct item by @vnbaaij in https://github.com/microsoft/fluentui-blazor/pull/755
* [FluentOptionPeople] Add ChildContent by @dvoituron in https://github.com/microsoft/fluentui-blazor/pull/728
* [FluentOverflow] Fix the Tooltip used by the FluentOverflow by @dvoituron in https://github.com/microsoft/fluentui-blazor/pull/678
* [FluentPresenceBadge  & FluentOptionPeople] - Update the Status badge to be compliant FluentUI 2 by @dvoituron in https://github.com/microsoft/fluentui-blazor/pull/732
* [FluentProgressToast] Changes by @vnbaaij in https://github.com/microsoft/fluentui-blazor/pull/657
* [FluentTreeItem] Fix select area when Text property is used by @ProH4Ck in https://github.com/microsoft/fluentui-blazor/pull/667
* [Multiple] Add `PreventScroll` to Dialog and Overlay by @vnbaaij in https://github.com/microsoft/fluentui-blazor/pull/758
* [Multiple] Apply the Immediate property to "text" components by @dvoituron in https://github.com/microsoft/fluentui-blazor/pull/696
* [Multiple] Set TextField.AutoComplete property to string type by @dvoituron in https://github.com/microsoft/fluentui-blazor/pull/682

#### General
* [CssBuilder and StyleBuilder] Fixing the built format and position of the custom styles by @dvoituron in https://github.com/microsoft/fluentui-blazor/pull/745
* [Documentation] Add UnitTests markdown page by @dvoituron in https://github.com/microsoft/fluentui-blazor/pull/658
* [Documentation] Update the Upgrade Guide and details on Icons by @dvoituron in https://github.com/microsoft/fluentui-blazor/pull/673
* Add MaxHeight to DemoSection by @vnbaaij in https://github.com/microsoft/fluentui-blazor/pull/740
* Fix #621  by @vnbaaij in https://github.com/microsoft/fluentui-blazor/pull/683
* Fix #674 by @vnbaaij in https://github.com/microsoft/fluentui-blazor/pull/676
* Fix Icons and Emojis trimmed during the WASM publishing by @dvoituron in https://github.com/microsoft/fluentui-blazor/pull/666
* fix typos by @LuohuaRain in https://github.com/microsoft/fluentui-blazor/pull/751
* Re-add scripts to index.html/_Layout.cshtml, Update docs by @vnbaaij in https://github.com/microsoft/fluentui-blazor/pull/697
* Rewrite the Icons.AllIcons property using relfection by @dvoituron in https://github.com/microsoft/fluentui-blazor/pull/685
* Update CodeSetup.md by @LuohuaRain in https://github.com/microsoft/fluentui-blazor/pull/730
* Update Fluent UI System Icons to 1.1.217  by @vnbaaij in https://github.com/microsoft/fluentui-blazor/pull/765

#### Templates
* Update templates by @vnbaaij in https://github.com/microsoft/fluentui-blazor/pull/688
* Add missing usings Project template by @agriffard in https://github.com/microsoft/fluentui-blazor/pull/702

#### New Contributors
* @agriffard made their first contribution in https://github.com/microsoft/fluentui-blazor/pull/702
* @hksalessio made their first contribution in https://github.com/microsoft/fluentui-blazor/pull/700
* @ssccinng made their first contribution in https://github.com/microsoft/fluentui-blazor/pull/711

Thanks to all contributors!

## V3.0.1
- Fix [#643](https://github.com/microsoft/fluentui-blazor/issues/643)**: Visual Studio 2022 freezes and then crashes with v3-RC-1
- Fix [#684](https://github.com/microsoft/fluentui-blazor/pull/684): Make FluentToastContainer work better on mobile devices
- Fix [#621](https://github.com/microsoft/fluentui-blazor/issues/621): Add area-hidden to FluentSearch clear button
- Fix [#674](https://github.com/microsoft/fluentui-blazor/issues/674): Collapse FluentNavMenuGroup on click if no custom action/href is assigned
- Fix [#680](https://github.com/microsoft/fluentui-blazor/issues/680): FluentTextField AutoComplete should be a string or enum and not a boolean 
- Fix [#668](https://github.com/microsoft/fluentui-blazor/issues/668): v3.0.0 IIS debugging/deployments 'Failed to load resource'
- Fix [#677](https://github.com/microsoft/fluentui-blazor/issues/677): FluentOverflow not working correctly
- Fix [#667](https://github.com/microsoft/fluentui-blazor/issues/667): FluentTreeItem select area when Text property is used
- Fix [#660](https://github.com/microsoft/fluentui-blazor/issues/660): Allow FluentMessageBox Text to not show an Icon
- Fix [#624](https://github.com/microsoft/fluentui-blazor/issues/624): v3 Unhandled exception rendering in NavMenuContent of FluentMainLayout
- Fix [#655](https://github.com/microsoft/fluentui-blazor/pull/655): ProgressToast rendering error for WASM

**) To fix this issue update Microsoft.Fast.Components.FluentUI.Icons v3.0.1 

### Other changes
- FluentCombobox, FluentSelect and FluentListbox now support Width and Height properties
- Update several documentation pages about how to use Icons and Emoji
- Included the script needed to implement Blazor Hybrid workaround easier (see readme)

## V3.0.0
** 26 New components**
- Header
- Footer
- BodyContent
- Grid
- Layout
- MainLayout
- Spacer
- Splitter
- Stack
- CounterBadge
- PresenceBadge
- CodeEditor
- Date & Time (Calendar, DatePicker, TimePicker)
- Dialog
- DragDrop
- Highlighter
- Label
- MessageBox
- Overflow
- Overlay
- Panel
- Popover
- SplashScreen
- Toast


**Completely redone components (and configuration)**
- Icon
- Emoji

**Other changes**
- Added initializersLoader.webview.js to work around Blazor Hybrid bug (see readme)

## Archives
For changes made befor version 3, see the [What's New archive](./content/FluentUI.Demo.Shared/docs/WhatsNew-Archive.md)