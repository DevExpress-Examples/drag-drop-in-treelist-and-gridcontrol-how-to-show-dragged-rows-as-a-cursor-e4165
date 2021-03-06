﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Grid;
using System.Collections;
using DevExpress.Xpf.Utils;

namespace Drag_Drop_rows
{
    public class ExternalDragDropViewInfo : DragDropViewInfo
    {
        new public static readonly DependencyProperty DraggingRowsProperty;
        new public static readonly DependencyProperty DropTargetRowProperty;
        new public static readonly DependencyProperty DropTargetTypeProperty;
        new public static readonly DependencyProperty FirstDraggingObjectProperty;
        new public static readonly DependencyProperty GroupInfoProperty;

        static ExternalDragDropViewInfo()
        {
            Type ownerType = typeof(ExternalDragDropViewInfo);
            DraggingRowsProperty = DependencyPropertyManager.Register("DraggingRows", typeof(IList), ownerType, new UIPropertyMetadata(null));
            DropTargetTypeProperty = DependencyPropertyManager.Register("DropTargetType", typeof(DropTargetType), ownerType, new UIPropertyMetadata(DropTargetType.None));
            DropTargetRowProperty = DependencyPropertyManager.Register("DropTargetRow", typeof(object), ownerType, new UIPropertyMetadata(null));
            GroupInfoProperty = DependencyPropertyManager.Register("GroupInfo", typeof(IList<GroupInfo>), ownerType, new UIPropertyMetadata(null));
            FirstDraggingObjectProperty = DependencyPropertyManager.Register("FirstDraggingObject", typeof(object), ownerType, new UIPropertyMetadata(null));
        }

        new public IList DraggingRows
        {
            get
            {
                return (IList)base.GetValue(DraggingRowsProperty);
            }
            set
            {
                base.SetValue(DraggingRowsProperty, value);
            }
        }

        new public object DropTargetRow
        {
            get
            {
                return base.GetValue(DropTargetRowProperty);
            }
            set
            {
                base.SetValue(DropTargetRowProperty, value);
            }
        }

        new public DropTargetType DropTargetType
        {
            get
            {
                return (DropTargetType)base.GetValue(DropTargetTypeProperty);
            }
            set
            {
                base.SetValue(DropTargetTypeProperty, value);
            }
        }

        new public object FirstDraggingObject
        {
            get
            {
                return base.GetValue(FirstDraggingObjectProperty);
            }
            set
            {
                base.SetValue(FirstDraggingObjectProperty, value);
            }
        }

        new public IList<GroupInfo> GroupInfo
        {
            get
            {
                return (IList<GroupInfo>)base.GetValue(GroupInfoProperty);
            }
            set
            {
                base.SetValue(GroupInfoProperty, value);
            }
        }
    }
}
