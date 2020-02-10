package com.example.ntustores;

import java.util.concurrent.Callable;

public class BaseCallback implements Callable<Void>
{
    public String pid;
    public String nNumber;

    @Override
    public Void call() throws Exception
    {
        return null;
    }
}
