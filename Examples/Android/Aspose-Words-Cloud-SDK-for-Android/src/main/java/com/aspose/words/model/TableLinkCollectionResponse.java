
package com.aspose.words.model;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class TableLinkCollectionResponse {

    @SerializedName("Tables")
    @Expose
    private Tables tables;
    @SerializedName("Code")
    @Expose
    private String code;
    @SerializedName("Status")
    @Expose
    private String status;

    public Tables getTables() {
        return tables;
    }

    public void setTables(Tables tables) {
        this.tables = tables;
    }

    public String getCode() {
        return code;
    }

    public void setCode(String code) {
        this.code = code;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }

}
