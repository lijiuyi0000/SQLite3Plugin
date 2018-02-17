// 

#include "ISQLite3.h"
#include "sqlite3.h"

DEFINE_LOG_CATEGORY(LogDatabase)

#define LOCTEXT_NAMESPACE "FSQLite3"

class FSQLite3 : public ISQLite3
{
    void StartupModule() override
    {
        sqlite3_initialize();
    }

    void ShutdownModule() override
    {
        sqlite3_shutdown();
    }
};

IMPLEMENT_MODULE(FSQLite3, SQLite3Plugin)

#undef LOCTEXT_NAMESPACE
