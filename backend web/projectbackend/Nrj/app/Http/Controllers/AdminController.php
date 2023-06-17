<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\User;

class AdminController extends Controller
{
    public function showUsers()
    {
        $users = User::all();
        return view('admin.users', compact('users'));
    }

    public function showUser($id)
    {
        $user = User::findOrFail($id);
        return view('admin.user', compact('user'));
    }

    public function promoteUser($id)
    {
        $user = User::findOrFail($id);
        $user->is_admin = true;
        $user->save();

        return redirect()->route('admin.users')->with('success', 'Gebruiker is succesvol bevorderd tot beheerder.');
    }

    public function demoteUser($id)
{
    $user = User::findOrFail($id);
    $user->is_admin = false;
    $user->save();

    return redirect()->route('admin.users')->with('success', 'Gebruiker is niet langer beheerder.');
}

}
