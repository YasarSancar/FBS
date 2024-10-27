SET FlatBuffersEditorCLI="C:\projects\rd_public\tools\FlatBuffersEditor\FlatBuffersEditorCLI.exe"
SET FLATC="C:\projects\rd_public\tools\asset_build_pipeline\test_env\flatc.exe"

%FlatBuffersEditorCLI% convert-schema --flatc-args "--cpp" --flatc-path %FLATC% -p audio.fbproj sources/bgm/bgm_layer.fbs
%FlatBuffersEditorCLI% convert-schema --flatc-args "--cpp" --flatc-path %FLATC% -p audio.fbproj sources/bgm/bgm_transition_rule.fbs
%FlatBuffersEditorCLI% convert-schema --flatc-args "--cpp" --flatc-path %FLATC% -p audio.fbproj sources/bgm/bgm_transition_override.fbs