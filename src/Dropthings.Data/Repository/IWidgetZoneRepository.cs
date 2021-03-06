﻿using System;
namespace Dropthings.Data.Repository
{
    public interface IWidgetZoneRepository : IDisposable
    {
        void Delete(Dropthings.Data.WidgetZone widgetZone);
        Dropthings.Data.WidgetZone GetWidgetZoneById(int widgetZoneId);
        Dropthings.Data.WidgetZone GetWidgetZoneByTabId_ColumnNo(int TabId, int columnNo);
        string GetWidgetZoneOwnerName(int widgetZoneId);
        Dropthings.Data.WidgetZone Insert(Dropthings.Data.WidgetZone zone);
        void Update(Dropthings.Data.WidgetZone zone);
    }
}
