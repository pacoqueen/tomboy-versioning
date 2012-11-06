//  
//  Versioning.cs
//  
//  Author:
//       Francisco José Rodríguez Bogado <frbogado@geotexan.com>
// 
//  Copyright (c) 2012 Francisco José Rodríguez Bogado
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using Mono.Unix;
using Gtk;
using Tomboy;

namespace Tomboy.Versioning
{
    public class VersioningAddin : NoteAddin
    {
        Gtk.MenuItem itemBack;
        Gtk.MenuItem itemFwd;
        
        public override void Initialize(){
            itemBack = new Gtk.MenuItem(Catalog.GetString("Back to previous version of this note."));
            itemBack.Activated += OnMenuBackActivated;
            itemBack.Show();
            AddPluginMenuItem(itemBack);
            
            itemFwd = new Gtk.MenuItem(Catalog.GetString("Forward to a later version of this note."));
            itemFwd.Activated += OnMenuFwdActivated;
            itemFwd.Show();
            AddPluginMenuItem(itemFwd);
        }
        
        public override void Shutdown(){
            itemBack.Activated -= OnMenuBackActivated;
            itemFwd.Activated -= OnMenuFwdActivated;
        }
        
        public override void OnNoteOpened(){}
        
        void OnMenuBackActivated(object sender, EventArgs args){
            Logger.Info("Activated 'Back to previous version' menu item.");
        }
        
        void OnMenuFwdActivated(object sender, EventArgs args){
            Logger.Info("Activated 'Forward to a later version' menu item.");
        }
    }
}
