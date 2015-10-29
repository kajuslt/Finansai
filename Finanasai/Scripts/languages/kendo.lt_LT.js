/*
* Kendo UI Localization Project for v2012.3.1114
* Copyright 2012 Telerik AD. All rights reserved.
*
* English US (en-US) Language Pack
*
* Project home : https://github.com/loudenvier/kendo-global
* Kendo UI home : http://kendoui.com
* Author : Felipe Machado (Loudenvier)
* http://feliperochamachado.com.br/index_en.html
*
* This project is released to the public domain, although one must abide to the
* licensing terms set forth by Telerik to use Kendo UI, as shown bellow.
*
* Telerik's original licensing terms:
* -----------------------------------
* Kendo UI Web commercial licenses may be obtained at
* https://www.kendoui.com/purchase/license-agreement/kendo-ui-web-commercial.aspx
* If you do not own a commercial license, this file shall be governed by the
* GNU General Public License (GPL) version 3.
* For GPL requirements, please review: http://www.gnu.org/copyleft/gpl.html
*/

kendo.ui.Locale = "Lithuanian LT (lt-LT)";
kendo.ui.ColumnMenu.prototype.options.messages =
  $.extend(kendo.ui.ColumnMenu.prototype.options.messages, {

      /* COLUMN MENU MESSAGES
      ****************************************************************************/
      sortAscending: "Rikiuoti didėjančiai",
      sortDescending: "Rikiuoti mažėjančiai",
      filter: "Filtras",
      columns: "Stulpeliai"
      /***************************************************************************/
  });

kendo.ui.Groupable.prototype.options.messages =
  $.extend(kendo.ui.Groupable.prototype.options.messages, {

      /* GRID GROUP PANEL MESSAGES
      ****************************************************************************/
      empty: "Užtempktite laukelį su pavadinimu, kad grupuoti pagal jį"
      /***************************************************************************/
  });

kendo.ui.FilterMenu.prototype.options.messages =
  $.extend(kendo.ui.FilterMenu.prototype.options.messages, {

      /* FILTER MENU MESSAGES
      ***************************************************************************/
      info: "Rodyti įrašus kurių reikšmė:", // sets the text on top of the filter menu
      isTrue: "lygi", // sets the text for "isTrue" radio button
      isFalse: "nelygi", // sets the text for "isFalse" radio button
      filter: "Filtruoti", // sets the text for the "Filter" button
      clear: "Išvalyti", // sets the text for the "Clear" button
      and: "ir",
      or: "arba",
      selectValue: "-Pasirinkite reikšmę-"
      /***************************************************************************/
  });

kendo.ui.FilterMenu.prototype.options.operators =
  $.extend(kendo.ui.FilterMenu.prototype.options.operators, {

      /* FILTER MENU OPERATORS (for each supported data type)
      ****************************************************************************/
      string: {
          eq: "lygi",
          neq: "nelygi",
          startswith: "prasideda tekstu",
          contains: "turi savyje tekstą",
          doesnotcontain: "neturi savyje teksto",
          endswith: "baigiasi tekstu"
      },
      number: {
          eq: "lygi",
          neq: "nelygi",
          gte: "ne mažesnė už",
          gt: "didesnė už",
          lte: "ne didesnė už",
          lt: "mažesnė už"
      },
      date: {
          eq: "lygi",
          neq: "nelygi",
          gte: "yra lygi arba vėlesnė nei",
          gt: "yra vėlesnė nei",
          lte: "yra lygi arba ankstesnė nei",
          lt: "yra ankstesnė nei"
      },
      enums: {
          eq: "lygi",
          neq: "nelygi"
      }
      /***************************************************************************/
  });

kendo.ui.Pager.prototype.options.messages =
  $.extend(kendo.ui.Pager.prototype.options.messages, {

      /* PAGER MESSAGES
      ****************************************************************************/
      display: "{0} - {1} iš {2} įrašų",
      empty: "Nėra įrašų atvaizdavimui",
      page: "Puslapis",
      of: "iš {0}",
      itemsPerPage: "įrašų skaičius puslapyje",
      first: "Eiti į pirmą puslapį",
      previous: "Eiti į ankstesnį puslapį",
      next: "Eiti į sekantį puslapį",
      last: "Eiti į paskutinį puslapį",
      refresh: "Atnaujinti"
      /***************************************************************************/
  });

kendo.ui.Validator.prototype.options.messages =
  $.extend(kendo.ui.Validator.prototype.options.messages, {

      /* VALIDATOR MESSAGES
      ****************************************************************************/
      required: "Laukas {0} yra privalomas",
      pattern: "Laukas {0} įvestas neteisingai",
      min: "Laukas {0} turi būti ne mažesnis už {1}",
      max: "Laukas {0} turi būti ne didesnis už {1}",
      step: "Laukas {0} įvestas neteisingai",
      email: "Lauko {0} reikšmė nėra el. pašto adresas",
      url: "Lauko {0} reikšmė nėra URL adresas",
      date: "Lauko {0} reikšmė nėra data"
      /***************************************************************************/
  });

kendo.ui.ImageBrowser.prototype.options.messages =
  $.extend(kendo.ui.ImageBrowser.prototype.options.messages, {

      /* IMAGE BROWSER MESSAGES
      ****************************************************************************/
      uploadFile: "Įkėlti",
      orderBy: "Rikiuoti pagal",
      orderByName: "Vardą",
      orderBySize: "Dydį",
      directoryNotFound: "Direktorija su tokiu pavadinimu nerasta.",
      emptyFolder: "Tuščias aplankas",
      deleteFile: 'Ar tikrai norite pašalinti šį failą "{0}"?',
      invalidFileType: "Pasirinkto failo \"{0}\" formatas netinkamas. Tinkami failo formatai: {1}.",
      overwriteFile: "Failas \"{0}\" jau egzistuoja nurodytoje direktorijoje. Ar norite jį pakeisti?",
      dropFilesHere: "tempkite failus čia, kad įkelti"
      /***************************************************************************/
  });

kendo.ui.Editor.prototype.options.messages =
  $.extend(kendo.ui.Editor.prototype.options.messages, {

      /* EDITOR MESSAGES
      ****************************************************************************/
      bold: "Paryškintas",
      italic: "Pasviręs",
      underline: "Pabrauktas",
      strikethrough: "Perbrauktas",
      superscript: "Padidintas",
      subscript: "Sumažintas",
      justifyCenter: "Centrinis išlygiavimas",
      justifyLeft: "Kairys išlygiavimas",
      justifyRight: "Dešinys išlygiavimas",
      justifyFull: "Suvienodintas išlygiavimas",
      insertUnorderedList: "Įterpti nerikiuojamą sąrašą",
      insertOrderedList: "Įterpti rikiuojamą sąrašą",
      indent: "Įtrauka",
      outdent: "Ištrauka",
      createLink: "Įterpti nuorodą",
      unlink: "Pašalinti nuorodą",
      insertImage: "Įterpti paveikslėlį",
      insertHtml: "Įterpti HTML",
      fontName: "Pasirinkti šriftą",
      fontNameInherit: "(paveldėtas šriftas)",
      fontSize: "Pasirinkti šrifto dydį",
      fontSizeInherit: "(paveldėtas dydis)",
      formatBlock: "Formatuoti",
      foreColor: "Spalva",
      backColor: "Fono spalva",
      style: "Stiliai",
      emptyFolder: "Tuščias aplankas",
      uploadFile: "Įkelti",
      orderBy: "Rikiuoti pagal:",
      orderBySize: "Dydį",
      orderByName: "PAvadinimą",
      invalidFileType: "Pasirinkto failo \"{0}\" formatas netinkamas. Tinkami formatai: {1}.",
      deleteFile: 'Ar tikrai norite pašalinti šį failą "{0}"?',
      overwriteFile: 'Failas "{0}" jau egzistuoja nurodytoje direktorijoje. Ar norite jį pakeisti?',
      directoryNotFound: "Direktorija su tokiu pavadinimu nerasta.",
      imageWebAddress: "WWW adresas",
      imageAltText: "Alternatyvus tekstas",
      dialogInsert: "Įterpti",
      dialogButtonSeparator: "arba",
      dialogCancel: "Atšaukti"
      /***************************************************************************/
  });