using ProjectQuebec.Code.FileHandle;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml;

namespace ProjectQuebec.Code
{
    public class EditorCore
    {
        public static async Task<string> EditorSyntax(FileObject xFile)
        {
            string xEditorSyntax, xMode = xFile.FileLanguage.Mode;
            string xContent = await new FileInteraction().ReadContent(xFile);
            string xTheme = "", xCompatibilityCode = "document.getElementById('code')";

            if (xContent.Contains("</textarea>"))
            {
                xContent = xContent.Replace("</textarea>", "</FORMULA544290TEXt4rea>");
                xCompatibilityCode = "removeTextAreaTag();";
            }

            if (App.Current.RequestedTheme == ApplicationTheme.Dark)
                xTheme = "theme: 'dracula',";

            if (xMode == "htmlmixed")
                xMode = @".js' type='text/javascript' charset='utf-8'></script><script src='ms-appx-web:///Syntax/mode/xml.js' type='text/javascript' charset='utf-8'></script><script src='ms-appx-web:///Syntax/mode/css.js' type='text/javascript' charset='utf-8'></script><script src='ms-appx-web:///Syntax/mode/javascript";

            if (xMode == "php")
                xMode = @".js' type='text/javascript' charset='utf-8'></script><script src='ms-appx-web:///Syntax/mode/htmlmixed.js' type='text/javascript' charset='utf-8'></script><script src='ms-appx-web:///Syntax/mode/xml.js' type='text/javascript' charset='utf-8'></script><script src='ms-appx-web:///Syntax/mode/javascript.js' type='text/javascript' charset='utf-8'></script><script src='ms-appx-web:///Syntax/mode/css.js' type='text/javascript' charset='utf-8'></script><script src='ms-appx-web:///Syntax/mode/clike.js' type='text/javascript' charset='utf-8'></script><script src='ms-appx-web:///Syntax/mode/php";

            xEditorSyntax = @"<!DOCTYPE html><html style='height:100%'>
                <head>
                    <meta charset='UTF-8'>
                    <meta name='viewport' content='width=device-width, initial-scale=1'>
                    <link  href='ms-appx-web:///Syntax/lib/codemirror.css' rel='stylesheet' type='text/css'/>
                    <link  href='ms-appx-web:///Syntax/theme/dracula.css' rel='stylesheet' type='text/css'/>
                    <link  href='ms-appx-web:///Syntax/addon/dialog/dialog.css' rel='stylesheet' type='text/css' />
                    <link  href='ms-appx-web:///Syntax/addon/hint/show-hint.css' rel='stylesheet' type='text/css' />
                    <script src='ms-appx-web:///Syntax/lib/codemirror.js' type='text/javascript' charset='utf-8'></script>
                    <script src='ms-appx-web:///Syntax/addon/dialog/dialog.js' type='text/javascript' charset='utf-8'></script>
                    <script src='ms-appx-web:///Syntax/addon/search/search.js' type='text/javascript' charset='utf-8'></script>
                    <script src='ms-appx-web:///Syntax/addon/search/searchcursor.js' type='text/javascript' charset='utf-8'></script>
                    <script src='ms-appx-web:///Syntax/mode/" + xMode + @".js' type='text/javascript' charset='utf-8'></script>
                </head>
                <body style='height:100%; padding:0; margin:0;'>
                    <textarea id='code' name='code' style='height:100%; margin:0; padding:0;'>" + @xContent + @"</textarea>
                    <script>
                        " + xCompatibilityCode + @"

                        var editor = CodeMirror.fromTextArea(document.getElementById('code'), {
                            lineNumbers: true,
                            lineWrapping: true,
                            foldGutter: true, " + xTheme + @"
                            mode: '" + @xFile.FileLanguage.Mime[0] + @"',
                            extraKeys: {
                                'Ctrl-O': function(){window.external.notify('METHOD=OPENFILE;');},
                                'Ctrl-S': function(){window.external.notify('METHOD=SAVEFILE;');},
                                'Ctrl-Alt-S': function(){window.external.notify('METHOD=SAVEALL;');},
                                'Shift-Ctrl-S': function(){window.external.notify('METHOD=SAVEALL;');},
                                'Ctrl-N': function(){window.external.notify('METHOD=ADDFILE;');},
                                'F11': function(){window.external.notify('METHOD=FULLSCREEN;');}
                            },
                        });

                        window.external.notify('NUMBEROFLINES=' + editor.lineCount() + ';');

                        editor.on('change', function() {
                            window.external.notify('NUMBEROFLINES=' + editor.lineCount() + ';ISCHANGED=TRUE;');
                        });
                        editor.on('cursorActivity', function() {
                            var lncl = editor.getCursor();
                            window.external.notify('LINE=' + lncl['line'] + ';COLUMN=' + lncl['ch'] +';');
                        });

                        function removeTextAreaTag(){
                            document.getElementById('code').value = document.getElementById('code').value.replace('</FORMULA544290TEXt4rea>','</textarea>');
                        }
                    </script>
                    <style> " + EditorCSS.CssToInclude() + @" </style>
                </body>
            </html>";

            //<script src='ms-appx-web:///Syntax/addon/hint/show-hint.js' type='text/javascript' charset='utf-8'></script>
            //<script src='ms-appx-web:///Syntax/addon/hint/css-hint.js' type='text/javascript' charset='utf-8'></script>

            //TODO: Criar opção de personalização para identUnit
            return xEditorSyntax;
        }
    }
}