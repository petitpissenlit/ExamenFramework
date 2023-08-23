<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Contact;

class ContactController extends Controller
{
    public function create()
    {
        return view('contact.contact');
    }

    public function store(Request $request)
    {
        $validatedData = $request->validate([
            'name' => 'required',
            'email' => 'required|email',
            'phone' => 'nullable',
            'message' => 'required',
        ]);

        Contact::create($validatedData);

        return redirect()->back()->with('success', 'Bedankt voor je bericht! We nemen spoedig contact met je op.');
    }

    public function admin()
    {
        $contacts = Contact::all();
        return view('contact.admin', compact('contacts'));
    }

 

    public function index()
    {
        $this->middleware('admin'); // Middleware om alleen admin-gebruikers toe te staan

        $contacts = Contact::all();

        return view('contact.admin', compact('contacts'));
    }


}
