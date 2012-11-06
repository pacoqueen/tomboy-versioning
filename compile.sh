#!/bin/bash

if [ ! -f /usr/lib/pkgconfig/gtk-sharp.pc ]; then 
    sudo ln -s /usr/lib/pkgconfig/gtk-sharp-2.0.pc /usr/lib/pkgconfig/gtk-sharp.pc
fi

gmcs -debug -out:Versioning.dll -target:library -pkg:tomboy-addins -r:Mono.Posix Versioning.cs -resource:Versioning.addin.xml -pkg:gtk-sharp $@
