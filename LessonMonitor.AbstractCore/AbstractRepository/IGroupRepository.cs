﻿using LessonMonitor.AbstractCore.DboModel;

namespace LessonMonitor.AbstractCore.AbstractRepository;

public interface IGroupRepository
{
    GroupDbo GetGroup(int groupID);
}
